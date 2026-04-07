using ExFixacao_Arquivos.Entities;
using System.Globalization;

namespace ExFixacao_Arquivos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\Dev\CsharpCompleto-ProgramacaoOrientadaObjetos\Secao11-Arquivos\ExFixacao-Arquivos\Files\products.csv";
                string sourceDirectoryPath = Path.GetDirectoryName(sourcePath);
                string targetDirectoryPath = Path.Combine(sourceDirectoryPath, "Out");
                string targetFilePath = Path.Combine(targetDirectoryPath, "summary.csv");

                Directory.CreateDirectory(targetDirectoryPath);

                List<Product> products = new List<Product>();

                using (StreamReader sr = new StreamReader(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] productData = sr.ReadLine().Split(',');
                        string name = productData[0];
                        double price = double.Parse(productData[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(productData[2]);

                        products.Add(new Product(name, price, quantity));
                    }
                }

                using (StreamWriter sw = new StreamWriter(targetFilePath))
                {
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product);
                    }
                }

                Console.WriteLine($"Arquivo 'summary.csv' criado com sucesso em {targetDirectoryPath}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}