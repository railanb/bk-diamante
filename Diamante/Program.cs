namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diamantTam;
            int meio;
            do
            {
                Console.Clear();

                Console.WriteLine("## Diamente de numero IMPAES ##\n" +
                    "Digite um numero impar: (Digite numero par para Sair) ");
                diamantTam = Convert.ToInt16(Console.ReadLine());

                if (imparNum(diamantTam) is false)
                {
                    Console.WriteLine("Apenas numero IMPAR");
                    return;
                }

                meio = diamantTam / 2;

                for (int i = 0; i <= meio; i++)
                {
                    espacoVertical(diamantTam, meio, i);
                    Console.WriteLine();
                }

                for (int i = meio - 1; i >= 0; i--)
                {
                    espacoVertical(diamantTam, meio, i);
                    Console.WriteLine();
                }
                Console.ReadKey();
            } while (imparNum(diamantTam));

        }

        private static void espacoVertical(int tamamanhoDiamante, int meio, int i)
        {
            for (int j = 0; j < tamamanhoDiamante; j++)
            {
                corpoDiamant(meio, i, j);
            }
        }

        private static void corpoDiamant(int meio, int i, int j)
        {
            bool validarLadoEsquerdo = j >= meio - i;
            bool validarLadoDireito = j <= meio + i;

            if (validarLadoEsquerdo && validarLadoDireito)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
        }

        static bool imparNum(int numero)
        {
            return numero % 2 != 0;
        }
    }
}
