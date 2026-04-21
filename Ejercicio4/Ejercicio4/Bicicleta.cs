using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Bicicleta:IVehiculo
    {
        private int velocidad = 10;
        private int posicion = 0;

        public void mover(int tiempo)
        {
            posicion += (velocidad * tiempo);
        }
        public int Posicion()
        {
            return posicion;
        }
        public void ReiniciarPosicion()
        {
            posicion = 0;
        }
    }
}
