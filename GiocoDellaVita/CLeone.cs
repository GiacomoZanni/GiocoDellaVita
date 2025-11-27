namespace GiocoDellaVita
{
    internal class CLeone : CPersonaggio
    {
        public CLeone(int x, int y) : base()
        {
            Energia = 35;
            _x = x;
            _y = y;
        }

        public override void Mangia()
        {
            if (Energia <= 25)
            {
                Energia += 10;
            }
            else if (Energia <= 35 && Energia > 25)
            {
                Energia = 35;
            }
        }

        public override void Muoviti(int x, int y)
        {
            if (Energia > 0)
            {
                _x = x;
                _y = y;
                Energia -= 1;
            }
            else
            {
                OnSonoMorto();
            }
        }

        public void MuovitiCasuale()
        {
            Random rnd = new Random;
            int direzione = rnd.Next(0, 7);
            switch (direzione)
            {
                case 0:
                    _x -= 1;
                    _y -= 1;
                    break;
                case 1:
                    _y -= 1;
                    break;
                case 2:
                    _x += 1;
                    _y -= 1;
                    break;
                case 3:
                    _x += 1;
                    break;
                case 4:
                    _x += 1;
                    _y += 1;
                    break;
                case 5:
                    _y += 1;
                    break;
                case 6:
                    _x -= 1;
                    _y += 1;
                    break;
                case 7:
                    _x -= 1;
                    break;
            }
        }
    }
}
