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

        private int _energia;
        protected int _x;
        protected int _y;

        public int Energia
        {
            get { return _energia; }
            set { _energia = value; }
        }

        public CPersonaggio() { }

        public virtual void Mangia()
        {
            throw new NotImplementedException();
        }

        public virtual void Muoviti(int x, int y)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnSonoMorto()
        {
            SonoMorto?.Invoke(this, EventArgs.Empty);
        }
    }
}
