using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    abstract class CPersonaggio
    {
        private int _salute;
        private int _stamina;
        private int[,] _posizione;

        public int Salute
        {
            get { return _salute; }
            set { _salute = value; }
        }

        public int Stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }

        public CPersonaggio() { }


    }
}
