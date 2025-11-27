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
    }
}
