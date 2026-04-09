namespace ExFixacao_Interfaces2.Services
{
    internal class Aviao : IFrete
    {
        private const int _quilometragemPorHora = 800;

        public double CalcularTempo(double distancia)
        {
            return distancia / _quilometragemPorHora;
        }
    }
}