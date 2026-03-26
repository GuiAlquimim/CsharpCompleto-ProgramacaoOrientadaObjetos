namespace ExFixacao_Matriz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("How many rows? ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("How many columns? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            Console.WriteLine();
            Console.WriteLine("Enter the values:");
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.Write("choose a number of the matrix: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Position: [{i},{j}]");
                        {
                            if (i > mat.GetLowerBound(0))
                                Console.WriteLine($"Up: {mat[i - 1, j]}");
                            if (j < mat.GetUpperBound(1))
                                Console.WriteLine($"Right: {mat[i, j + 1]}");
                            if (i < mat.GetUpperBound(0))
                                Console.WriteLine($"Down: {mat[i + 1, j]}");
                            if (j > mat.GetLowerBound(1))
                                Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}