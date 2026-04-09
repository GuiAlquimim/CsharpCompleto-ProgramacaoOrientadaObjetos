namespace ExFixacao_Interfaces2.Services
{
    internal class Carro : IFrete
    {
        private const int _quilometragemPorHora = 60;

        public double CalcularTempo(double distancia)
        {
            return distancia / _quilometragemPorHora;
        }
    }
}