using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CCarota : CPersonaggio
    {
        public CCarota(int x, int y) : base()
        {
            Energia = 10;
            _x = x;
            _y = y;
        }
    }
}
