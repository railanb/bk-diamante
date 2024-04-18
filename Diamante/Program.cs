namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 21;

            int meio = tamanho / 2;

            // Imprime a parte superior do diamante
            for (int i = 0; i < meio; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (j >= meio - i && j <= meio + i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Imprime a parte inferior do diamante
            for (int i = meio; i >= 0; i--)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (j >= meio - i && j <= meio + i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
