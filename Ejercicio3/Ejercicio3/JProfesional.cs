using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class JProfesional : Interfaz
    {
        private int minutosRecorridos = 0;
        private bool Cansado = false;

        public bool correr(int minutos)
        {
            if (Cansado) return false;

            if ((minutosRecorridos += minutos) <= 40)
            {
                if (minutosRecorridos == 40) Cansado = true;
                return true;
            }
            else
            {
                minutosRecorridos = 40;
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

            if (minutosRecorridos < 40) Cansado = false;
        }
    }
}

