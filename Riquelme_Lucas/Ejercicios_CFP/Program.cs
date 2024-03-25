namespace Ejercicios_CFP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ingrese nombre, lo lea, ingrese apellido, lo lea, y mensaje de bienvenida completo
            string nombre;
            string apellido;
            string edad;
            int edadInt;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            //ingrese su edad
            Console.WriteLine("Ingrese su edad: ");
            edad = Console.ReadLine();
            edadInt = int.Parse(edad);
            //Console.WriteLine("Bienvenido " + nombre + " "+ apellido + " su edad es de " + edad + " años.");
            Console.WriteLine($"Bienvenido {nombre} {apellido} su edad es de {edad} años.");
        }
    }
}
