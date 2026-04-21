using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Semaforo
    {
        public string Color;
        public int tiempo;
        public bool EsIntermitente;
        public Semaforo(string colorI)
        { 
            Color = colorI;
            tiempo = 0;
            EsIntermitente = false;
        }
        public void PonerIntermitente() 
        {
            EsIntermitente = true;
        }
        public void SacarIntermitente() 
        {
            EsIntermitente = false;
        }
        public void MostrarColor() 
        {
            if (EsIntermitente) { String estado = (tiempo % 2 == 0) ? "Amarillo" : " Apagado ";
                Console.WriteLine("el color es: " + estado);
            }
            else
            {
                Console.WriteLine("el color es: " + Color);
            }
        }
        public void PasoDelTiempo(int segundos)
        {
            tiempo += segundos;
        }
        public void ActualizarColor() 
        {
            if (Color == "Rojo" && tiempo >= 30) 
            {
                Color = "Rojo + Amarillo";
                tiempo = 0;
            }
            if (Color == "Rojo + Amarillo" && tiempo >= 2)
            {
                Color = "Verde"; tiempo = 0;
            }
            if (Color == "Verde" && tiempo >= 20)
            {
                Color = "Amarillo"; tiempo = 0;
            }
            if (Color == "Amarillo" && tiempo >= 2)
            {
                Color = "Rojo"; tiempo = 0;
            }
        }
    }

}

