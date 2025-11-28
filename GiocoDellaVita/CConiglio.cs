using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CConiglio : CPersonaggio
    {
        public CConiglio(int x, int y) : base()
        {
            Energia = 25;
            _x = x;
            _y = y;
        }
        public override void Mangia()
        {
            if (Energia <= 15)
            {
                Energia += 10;
            }
            else if (Energia <= 25 && Energia > 15)
            {
                Energia = 25;
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
            Random rnd = new Random();
            int direzione = rnd.Next(0, 8);
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
