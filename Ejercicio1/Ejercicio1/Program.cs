namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaforo semaforo = new Semaforo("Verde");
            semaforo.MostrarColor();
            semaforo.PasoDelTiempo(20);
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
            semaforo.PasoDelTiempo(2);
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
            semaforo.PasoDelTiempo(30);
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
            semaforo.PasoDelTiempo(2);
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
            semaforo.PonerIntermitente();
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
            semaforo.PasoDelTiempo(1);
            semaforo.MostrarColor();
            semaforo.SacarIntermitente();
            semaforo.ActualizarColor();
            semaforo.MostrarColor();
        }
    }
}
