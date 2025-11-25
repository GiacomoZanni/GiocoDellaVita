using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    internal interface IAnimale
    {
        public void Mangia();
        public void Muoviti(int[,] posizione);
    }
}
