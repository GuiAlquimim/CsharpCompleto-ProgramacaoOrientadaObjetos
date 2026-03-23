using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao2_ClassesAtributosMetodos
{
    internal class Funcionario
    {
        private string Nome { get; set; }
        private double SalarioBruto { get; set; }
        private double Imposto { get; set; }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto += aumento;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("f2")}";
        }
    }
}