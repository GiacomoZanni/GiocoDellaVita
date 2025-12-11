namespace GiocoDellaVitaForm
{
    public partial class Form1 : Form
    {
        string[,] tab = new string[7, 7];
        Random rnd = new Random();
        CLeone leone;
        CConiglio coniglio;
        CCarota carota;
        bool leonescelto = false;
        bool coniglioscelto = false;



        public Form1()
        {
            InitializeComponent();
            InizializzaTabella();
        }

        void InizializzaTabella()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    tab[i, j] = "-";
            coniglio = new CConiglio(0, 0);
            leone = new CLeone(6, 6);
            leone.PersonaggioMorto += Morto;
            coniglio.PersonaggioMorto += Morto;
            carota = GeneraCarota();
            AggiornaTabella();
            StampaMatriceSuTextBox();
        }

        CCarota GeneraCarota()
        {
            int x, y;
            do
            {
                x = rnd.Next(0, 7);
                y = rnd.Next(0, 7);
            }
            while ((x == coniglio.X && y == coniglio.Y) ||
                   (x == leone.X && y == leone.Y));
            return new CCarota(x, y);
        }

        void AggiornaTabella()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    tab[i, j] = "-";

            tab[coniglio.X, coniglio.Y] = "c";
            tab[leone.X, leone.Y] = "l";
            tab[carota.X, carota.Y] = "t";
            StampaMatriceSuTextBox();
        }

        void StampaMatriceSuTextBox()
        {
            textBox1.Text = tab[0, 0];
            textBox2.Text = tab[0, 1];
            textBox3.Text = tab[0, 2];
            textBox4.Text = tab[0, 3];
            textBox5.Text = tab[0, 4];
            textBox6.Text = tab[0, 5];
            textBox7.Text = tab[0, 6];
            textBox8.Text = tab[1, 0];
            textBox9.Text = tab[1, 1];
            textBox10.Text = tab[1, 2];
            textBox11.Text = tab[1, 3];
            textBox12.Text = tab[1, 4];
            textBox13.Text = tab[1, 5];
            textBox14.Text = tab[1, 6];
            textBox15.Text = tab[2, 0];
            textBox16.Text = tab[2, 1];
            textBox17.Text = tab[2, 2];
            textBox18.Text = tab[2, 3];
            textBox19.Text = tab[2, 4];
            textBox20.Text = tab[2, 5];
            textBox21.Text = tab[2, 6];
            textBox22.Text = tab[3, 0];
            textBox23.Text = tab[3, 1];
            textBox24.Text = tab[3, 2];
            textBox25.Text = tab[3, 3];
            textBox26.Text = tab[3, 4];
            textBox27.Text = tab[3, 5];
            textBox28.Text = tab[3, 6];
            textBox29.Text = tab[4, 0];
            textBox30.Text = tab[4, 1];
            textBox31.Text = tab[4, 2];
            textBox32.Text = tab[4, 3];
            textBox33.Text = tab[4, 4];
            textBox34.Text = tab[4, 5];
            textBox35.Text = tab[4, 6];
            textBox36.Text = tab[5, 0];
            textBox37.Text = tab[5, 1];
            textBox38.Text = tab[5, 2];
            textBox39.Text = tab[5, 3];
            textBox40.Text = tab[5, 4];
            textBox41.Text = tab[5, 5];
            textBox42.Text = tab[5, 6];
            textBox43.Text = tab[6, 0];
            textBox44.Text = tab[6, 1];
            textBox45.Text = tab[6, 2];
            textBox46.Text = tab[6, 3];
            textBox47.Text = tab[6, 4];
            textBox48.Text = tab[6, 5];
            textBox49.Text = tab[6, 6];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SceltaLeone_Click(object sender, EventArgs e)
        {
            leonescelto = true;
            coniglioscelto = false;
        }

        private void SceltaConiglio_Click(object sender, EventArgs e)
        {
            leonescelto = false;
            coniglioscelto = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(1);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(1);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(2);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(2);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(3);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(3);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(4);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(4);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(5);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(5);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(6);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(6);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(7);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(7);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int mov = rnd.Next(1, 9);
            if (coniglioscelto == false)
            {
                leone.Muoviti(8);
                coniglio.Muoviti(mov);
            }
            else
            {
                coniglio.Muoviti(8);
                leone.Muoviti(mov);
            }
            AggiornaTabella();
        }

        private void Morto(object sender, CPersonaggio p)
        {
            if (leone.Energia <= 0)
            {
                textBox50.Text = "Il leone è morto! GAME OVER";
            }
            else if (coniglio.Energia <= 0)
            {
                textBox50.Text = "Il coniglio è morto! GAME OVER";
            }
        }
    }
}