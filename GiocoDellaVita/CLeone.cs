using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CLeone : CPersonaggio
    {
        public CLeone(int[,] posizione) : base()
        {
            Salute = 50;
            Stamina = 25;
            _posizione = posizione;
        }

        public override void Mangia()
        {
            if (Salute <= 43)
            {
                Salute += 7;
            }
            else if (Salute <= 50 && Salute > 43)
            {
                Salute = 50;
            }
        }

        public override void Muoviti(int[,] posizione)
        {
            if (Stamina > 0)
            {
                _posizione = posizione;
                Stamina -= 1;
            }
        }


    }
}
