namespace ExFixacao_Interfaces2.Services
{
    internal class CalculadoraDeEntrega
    {
        private IFrete _frete;

        public CalculadoraDeEntrega(IFrete frete)
        {
            _frete = frete;
        }

        public string ExibirPrevisao(double distancia)
        {
            return $"A entrega chegará em {_frete.CalcularTempo(distancia).ToString("f2")} hora(s)";
        }
    }
}