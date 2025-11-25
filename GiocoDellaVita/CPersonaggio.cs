using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    abstract class CPersonaggio : IAnimale
    {
        public event EventHandler SonoMorto;

        private int _salute;
        private int _stamina;
        protected int[,] _posizione;

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

        public virtual void Mangia()
        {
            throw new NotImplementedException();
        }

        public virtual void Muoviti(int[,] posizione)
        {
            throw new NotImplementedException();
        }
    }
}
