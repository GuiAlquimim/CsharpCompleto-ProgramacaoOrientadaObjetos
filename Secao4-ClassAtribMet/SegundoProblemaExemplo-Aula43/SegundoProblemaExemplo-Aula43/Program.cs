namespace SegundoProblemaExemplo_Aula43
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProduto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutoEmEstoque(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}