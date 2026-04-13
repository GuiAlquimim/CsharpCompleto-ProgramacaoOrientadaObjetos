namespace ExFixacao_Dictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"C:\Dev\CsharpCompleto-ProgramacaoOrientadaObjetos\Secao13-GeneSetDict\ExFixacao-Dictionary\Files\Votes registration.txt";

            Dictionary<string, int> votesRegistration = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (votesRegistration.ContainsKey(name))
                            votesRegistration[name] += votes;
                        else
                            votesRegistration.Add(name, votes);
                    }
                }

                foreach (KeyValuePair<string, int> item in votesRegistration)
                {
                    Console.WriteLine($"{item.Key}, {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}