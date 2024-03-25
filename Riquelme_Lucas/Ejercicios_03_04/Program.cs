using System.Diagnostics.CodeAnalysis;

namespace Ejercicios_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03) Ingresar 2 números y mostrar la suma de los mismos.

            //int primer_numero;
            //int segundo_numero;
            //int suma;
            //Console.WriteLine("Ingrese el primer numero:");
            //primer_numero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el segundo numero:");
            //segundo_numero = int.Parse(Console.ReadLine());

            //suma = primer_numero + segundo_numero;
            //Console.WriteLine("La suma de ambos numeros es: " + suma);

            //04) Ingresar 5 números enteros, calcular y mostrar el promedio.

            int primer_numero;
            int segundo_numero;
            int tercer_numero;
            int cuarto_numero;
            int quinto_numero;
            double promedio;

            Console.WriteLine("Ingrese el primer numero:");
            primer_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            segundo_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            tercer_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero:");
            cuarto_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero:");
            quinto_numero = int.Parse(Console.ReadLine());

            promedio = (primer_numero + segundo_numero + tercer_numero + cuarto_numero + quinto_numero) / 5;
            Console.WriteLine("El promedio entre los 5 numeros es de: " + promedio);

        }
    }
}
