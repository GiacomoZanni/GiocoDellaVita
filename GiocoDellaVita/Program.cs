namespace GiocoDellaVita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tabellone = new string[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int l = 0; l < 7; l++)
                {
                    tabellone[i, l] = "O";
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int l = 0; l < 7; l++)
                {
                    Console.Write($"{tabellone[i, l]} ");
                }
                Console.WriteLine();
            }
        }

        public void LeoneMorto()
        {
            Console.WriteLine("Oh no! La stanchezza ha avuto la meglio!");
        }

        public void CongiglioMorto()
        {
            Console.WriteLine("Oh no! Il leone mi ha preso!");
        }
    }
}