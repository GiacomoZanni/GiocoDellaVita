using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CCarota : CPersonaggio
    {
        public CCarota(int x, int y)
        {
            X = x;
            Y = y;
            Energia = 10;
        }

        public override void Mangia() { }

        public override void Muoviti(int direzione) { }
    }
}
