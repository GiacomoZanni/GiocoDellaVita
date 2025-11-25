using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal class CCarota : CPersonaggio
    {
        public CCarota(int[,] posizione) : base()
        {
            Salute = 10;
            Stamina = 10;
            _posizione = posizione;
        }
    }
}
