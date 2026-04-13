using System.Globalization;

namespace ExFixacao_ExtensionMet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = "TesTANDO MEu métODO de extensão to title case()";
            Console.WriteLine(text);
            Console.WriteLine(text.ToTitleCase());

            Console.WriteLine();

            Console.WriteLine("Teste do método de extensão ToRelativeTime()");
            DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(1));
            Console.WriteLine(date.ToString("g", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine(date.ToRelativeTime());
        }
    }
}