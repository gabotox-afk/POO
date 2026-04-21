namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto fiat = new Auto(45);
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();

            bici.mover(20);
            Console.WriteLine(bici.Posicion());
            bici.mover(10);
            Console.WriteLine(bici.Posicion());
            Console.WriteLine("Camion");
            camion.mover(20);
            Console.WriteLine(camion.Posicion());
            camion.mover(10);
            Console.WriteLine(camion.Posicion());
            Console.WriteLine("Auto");
            fiat.mover(20);
            Console.WriteLine(fiat.Posicion());
            fiat.mover(10);
            Console.WriteLine(fiat.Posicion());
            fiat.ReiniciarPosicion();
            Console.WriteLine(fiat.Posicion());

        }
    }
}
