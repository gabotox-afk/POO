using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class cronometro
    {
        private int segundos;
        private int minutos;

        public cronometro()
        {
            reiniciar();
        }
        public void reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }

        public void IncrementarTiempo()
        {
            if(segundos == 59)
            {
                segundos = 0;
                minutos++;
            }
            else
            {
                segundos++;
            }

        }

        public void MostrarTiempo()
        {
            Console.WriteLine(minutos + "minutos, " + segundos + "segundos");
        }
    }
}
