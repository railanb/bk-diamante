namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Diamantes de x Dado um número ímpar, exiba um diamante desenhado com a letra ‘x’.
            */
            int tamamanhoDiamante = 0;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Title = "Diamante";

                Console.WriteLine("Quero imprimir um diamante para números impar.\r\n" +
                    "Entre com o tamanho do diamante:");
                tamamanhoDiamante = Convert.ToInt16(Console.ReadLine());

                if (DeveSerImpar(tamamanhoDiamante) is false)
                {
                    Console.WriteLine("Preciso de um número impar");
                    return;
                }

                int meio = tamamanhoDiamante / 2;

                for (int i = 0; i <= meio; i++)
                {
                    PercorrerEspaçosVertical(tamamanhoDiamante, meio, i);
                    Console.WriteLine();
                }

                for (int i = meio - 1; i >= 0; i--)
                {
                    PercorrerEspaçosVertical(tamamanhoDiamante, meio, i);
                    Console.WriteLine();
                }
                Console.ReadKey();
            } while (DeveSerImpar(tamamanhoDiamante));

        }

        private static void PercorrerEspaçosVertical(int tamamanhoDiamante, int meio, int i)
        {
            for (int j = 0; j < tamamanhoDiamante; j++)
            {
                ValidarCorpoDiamante(meio, i, j);
            }
        }

        private static void ValidarCorpoDiamante(int meio, int i, int j)
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

        static bool DeveSerImpar(int numero)
        {
            return numero % 2 != 0;
        }
    }
}
