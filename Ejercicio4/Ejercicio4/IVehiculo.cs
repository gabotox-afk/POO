using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal interface IVehiculo
    {
        public void mover(int tiempo);
        public int Posicion();
        public void ReiniciarPosicion();
    }
}
