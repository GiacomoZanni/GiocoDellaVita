using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CConiglio : CPersonaggio
    {
        public CConiglio(int x, int y)
        {
            X = x;
            Y = y;
            Energia = 25;
        }

        public override void Mangia()
        {
            Energia = Math.Min(Energia + 10, 25);
        }

        public override void Muoviti(int direzione)
        {
            int nx = X, ny = Y;

            switch (direzione)
            {
                case 1: nx--; ny--; break;
                case 2: ny--; break;
                case 3: nx++; ny--; break;
                case 4: nx++; break;
                case 5: nx++; ny++; break;
                case 6: ny++; break;
                case 7: nx--; ny++; break;
                case 8: nx--; break;
            }

            ControllaBordo(ref nx, ref ny);
            X = nx;
            Y = ny;

            Energia--;
            OnPersonaggioMorto();
        }
    }
}
