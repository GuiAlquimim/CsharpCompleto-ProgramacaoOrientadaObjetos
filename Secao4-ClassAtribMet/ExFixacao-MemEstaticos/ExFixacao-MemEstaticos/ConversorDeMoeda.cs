using System;
using System.Collections.Generic;
using System.Text;

namespace ExFixacao_MemEstaticos
{
    internal class ConversorDeMoeda
    {
        static double IOF = 0.06;

        public static double ValorCotacao(double cotacao, double quantidade)
        {
            double taxa = cotacao * quantidade * IOF;
            return cotacao * quantidade + taxa;
        }
    }
}
