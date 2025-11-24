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
    }
}
