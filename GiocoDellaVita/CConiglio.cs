using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CConiglio : CPersonaggio
    {
        public CConiglio(int[,] posizione) : base()
        {
            Salute = 25;
            Stamina = 35;
            _posizione = posizione;
        }
    }
}
