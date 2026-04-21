using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Auto:IVehiculo
    {
        private int velocidad;
        private int posicion;

        public Auto(int kmh)
        {
            velocidad = kmh;
            posicion = 0;
        }
        
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
