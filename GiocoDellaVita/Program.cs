namespace GiocoDellaVita
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[,] tabellone = new string[7, 7];

            InizializzaTabellone(tabellone);

            CLeone leone = new CLeone(6, 6);
            CConiglio coniglio = new CConiglio(0, 0);

            CCarota carota = GeneraCarota(tabellone, leone, coniglio);

            leone.PersonaggioMorto += PersonaggioMorto;
            coniglio.PersonaggioMorto += PersonaggioMorto;
            carota.PersonaggioMorto += CarotaMorta;

            Console.WriteLine("Vuoi essere il coniglio o il leone? (c/l)");
            string personaggio = Console.ReadLine();

            while (leone.Energia > 0 && coniglio.Energia > 0)
            {
                Console.Clear();
                AggiornaTabellone(tabellone, coniglio, leone, carota);
                StampaTabellone(tabellone);

                if (personaggio == "c")
                {
                    Console.WriteLine("Muovi il coniglio (1-8):");
                    int dir = int.Parse(Console.ReadLine());
                    coniglio.Muoviti(dir);

                    // La carota perde energia se il coniglio si muove
                    carota.Energia--;
                    carota.OnPersonaggioMorto();

                    // Coniglio mangia la carota
                    if (coniglio.X == carota.X && coniglio.Y == carota.Y)
                    {
                        coniglio.Mangia();
                        Console.WriteLine("Il coniglio ha mangiato la carota!");
                        carota = RespawnCarota(tabellone, leone, coniglio);
                    }

                    // Movimento leone
                    leone.Muoviti(rnd.Next(1, 9));

                    if (coniglio.X == leone.X && coniglio.Y == leone.Y)
                    {
                        Console.WriteLine("Il leone ha mangiato il coniglio! Game Over.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Muovi il leone (1-8):");
                    int dir = int.Parse(Console.ReadLine());
                    leone.Muoviti(dir);

                    coniglio.Muoviti(rnd.Next(1, 9));

                    // Carota perde energia
                    carota.Energia--;
                    carota.OnPersonaggioMorto();

                    if (coniglio.X == leone.X && coniglio.Y == leone.Y)
                    {
                        Console.WriteLine("Il leone ha mangiato il coniglio! Game Over.");
                        break;
                    }
                }

                Console.ReadKey();
            }
        }

        static void InizializzaTabellone(string[,] tab)
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    tab[i, j] = "-";
        }

        static void AggiornaTabellone(string[,] tab, CConiglio c, CLeone l, CCarota t)
        {
            InizializzaTabellone(tab);
            tab[c.X, c.Y] = "c";
            tab[l.X, l.Y] = "l";
            tab[t.X, t.Y] = "t";
        }

        static void StampaTabellone(string[,] tab)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                    Console.Write(tab[i, j] + " ");
                Console.WriteLine();
            }
        }

        static CCarota GeneraCarota(string[,] tab, CLeone l, CConiglio c)
        {
            int x, y;
            do
            {
                x = rnd.Next(0, 7);
                y = rnd.Next(0, 7);
            } while ((x == l.X && y == l.Y) || (x == c.X && y == c.Y));

            return new CCarota(x, y);
        }

        static CCarota RespawnCarota(string[,] tab, CLeone l, CConiglio c)
        {
            Console.WriteLine("La carota è ricresciuta altrove!");
            return GeneraCarota(tab, l, c);
        }

        static void PersonaggioMorto(object sender, CPersonaggio p)
        {
            if (p is CLeone)
                Console.WriteLine("Il leone è morto! Game Over.");
            else if (p is CConiglio)
                Console.WriteLine("Il coniglio è morto! Game Over.");
        }

        static void CarotaMorta(object sender, CPersonaggio p)
        {
            Console.WriteLine("La carota è marcita e ricresce!");
        }
    }
}