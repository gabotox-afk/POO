namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interfaz jugadorA = new JAmateur();
            Interfaz jugadorB = new JProfesional();

            Console.WriteLine(jugadorA.cansado());
            jugadorA.correr(20);
            Console.WriteLine(jugadorA.cansado());
            jugadorA.correr(1);
            Console.WriteLine(jugadorA.cansado());
            Console.WriteLine(jugadorA.correr(1));
            jugadorA.descansar(3);
            Console.WriteLine(jugadorA.correr(3));

            Console.WriteLine("jugadorB");

            Console.WriteLine(jugadorB.cansado());
            jugadorB.correr(40);
            Console.WriteLine(jugadorB.cansado());
            jugadorB.correr(1);
            Console.WriteLine(jugadorB.cansado());
            Console.WriteLine(jugadorB.correr(1));
            jugadorB.descansar(3);
            Console.WriteLine(jugadorB.correr(3));



        }
    }
}
