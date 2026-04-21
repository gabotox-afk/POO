namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cronometro cronometro = new cronometro();
            for (int i = 0; i < 5000; i++)
            {
                cronometro.IncrementarTiempo();
            }
            cronometro.MostrarTiempo();

        }
    }
}
