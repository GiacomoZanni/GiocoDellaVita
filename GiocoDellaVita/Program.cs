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
                    tabellone[i, l] = "-";
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
            Console.WriteLine("Vuoi essere il coniglio o il leone? (c/l)");
            string personaggio = Console.ReadLine();
            if (personaggio == "c")
            {
                CConiglio coniglio = new CConiglio( 0, 0 );
                tabellone[0, 0] = "c";
                tabellone[6, 6] = "l";
                CLeone leone = new CLeone(7, 7);
                Random rnd = new Random();
                int x = rnd.Next(0, 7);
                Random rand = new Random();
                int y = rnd.Next(0, 7);
                CCarota carota = new CCarota(x, y);
                for (int i = 0; i < 7; i++)
                {
                    for (int l = 0; l < 7; l++)
                    {
                        tabellone[i, l] = "-";
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
            else if (personaggio == "l")
            {
                CLeone leone = new CLeone(7, 7);
                tabellone[0, 0] = "c";
                tabellone[6, 6] = "l";
                CConiglio coniglio = new CConiglio(0, 0);
                Random rnd = new Random();
                int x = rnd.Next(0, 7);
                Random rand = new Random();
                int y = rnd.Next(0, 7);
                CCarota carota = new CCarota(x, y);
                for (int v = 0; v < 7; v++)
                {
                    for (int l = 0; l < 7; l++)
                    {
                        tabellone[v, l] = "-";
                    }
                }
                for (int v = 0; v < 7; v++)
                {
                    for (int l = 0; l < 7; l++)
                    {
                        Console.Write($"{tabellone[v, l]} ");
                    }
                    Console.WriteLine();
                }
                int i = 0;
                while (i == 0)
                {
                    if (leone.Energia == 0)
                    {
                        break;
                    }
                    Console.WriteLine("In che direzione vuoi muoverti?");
                    Console.WriteLine("1 in alto e a sinistra");
                    Console.WriteLine("2 in alto");
                    Console.WriteLine("3 in alto e a destra");
                    Console.WriteLine("4 a destra");
                    Console.WriteLine("5 in basso e a destra");
                    Console.WriteLine("6 in basso");
                    Console.WriteLine("7 in basso e a sinistra");
                    Console.WriteLine("8 a sinistra");
                    int direzione = int.Parse(Console.ReadLine());
                    switch (direzione)
                    {
                        case 1:
                            tabellone[x, y] = "O";
                            x -= 1;
                            y -= 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            tabellone[x, y] = "O";
                            y -= 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            tabellone[x, y] = "O";
                            x += 1;
                            y -= 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            tabellone[x, y] = "O";
                            x += 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            tabellone[x, y] = "O";
                            x += 1;
                            y += 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 6:
                            tabellone[x, y] = "O";
                            y += 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 7:
                            tabellone[x, y] = "O";
                            x -= 1;
                            y += 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 8:
                            tabellone[x, y] = "O";
                            x -= 1;
                            tabellone[x, y] = "l";
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    tabellone[v, l] = "-";
                                }
                            }
                            for (int v = 0; v < 7; v++)
                            {
                                for (int l = 0; l < 7; l++)
                                {
                                    Console.Write($"{tabellone[v, l]} ");
                                }
                                Console.WriteLine();
                            }
                            break;
                    }
                }
            }
        }

        public string LeoneMorto()
        {
            string messaggio="Oh no! La stanchezza ha avuto la meglio!";
            return messaggio;
        }

        public void CongiglioMorto()
        {
            Console.WriteLine("Oh no! Il leone mi ha preso!");
        }
    }
}