using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class JAmateur : Interfaz
    {
        private int minutosRecorridos = 0;
        private bool Cansado = false;

        public bool correr(int minutos)
        {
            if (Cansado) return false;

            if ( (minutosRecorridos += minutos) <= 20)
            {
                if (minutosRecorridos == 20) Cansado = true;
                return true;
            }
            else
            {
                minutosRecorridos = 20;
                Cansado = true;
                return false;
            }

        }

        public bool cansado()
        {
            return Cansado;
        }

        public void descansar(int minutos)
        {
            minutosRecorridos -= minutos;

            if (minutosRecorridos < 20) Cansado = false;
        }
    }
}
