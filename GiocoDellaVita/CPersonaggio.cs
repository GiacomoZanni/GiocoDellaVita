using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    abstract class CPersonaggio : IAnimale
    {
        public int Energia { get; set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public event EventHandler<CPersonaggio> PersonaggioMorto;

        public abstract void Mangia();
        public abstract void Muoviti(int direzione);

        protected void ControllaBordo(ref int x, ref int y)
        {
            x = Math.Max(0, Math.Min(6, x));
            y = Math.Max(0, Math.Min(6, y));
        }

        public void VerificaMorte()
        {
            if (Energia <= 0)
                PersonaggioMorto?.Invoke(this, this);
        }
    }
}
