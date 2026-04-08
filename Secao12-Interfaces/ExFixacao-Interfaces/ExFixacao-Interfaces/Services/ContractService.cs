using ExFixacao_Interfaces.Entities;

namespace ExFixacao_Interfaces.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(WorkContract contract, int months)
        {
            double installmentValue = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime installmentDate = contract.Date.AddMonths(i);
                double updatedValue = installmentValue + _onlinePaymentService.PaymentFee(installmentValue);
                double finalValue = updatedValue + _onlinePaymentService.Interest(updatedValue, i);
                contract.AddInstallment(new Installment(installmentDate, finalValue));
            }
        }
    }
}