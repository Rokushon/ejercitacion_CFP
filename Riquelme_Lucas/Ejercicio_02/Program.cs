namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar el nombre y apellido por consola.

            string nombre;
            string apellido;
            int edad;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
        }
    }
}
