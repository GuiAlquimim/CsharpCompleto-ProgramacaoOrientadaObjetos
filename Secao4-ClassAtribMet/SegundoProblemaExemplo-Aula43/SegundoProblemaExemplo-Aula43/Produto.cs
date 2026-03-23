using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProblemaExemplo_Aula43
{
    internal class Produto
    {
        private string Nome { get; set; }
        private double Preco { get; set; }
        private int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarProdutoEmEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("f2")}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("f2")}";
        }
    }
}
