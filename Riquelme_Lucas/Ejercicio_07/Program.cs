using System.Runtime.ConstrainedExecution;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 15 números y determinar:
            //Suma de los negativos.
            //Suma de los positivos.
            //Cantidad de positivos.
            //Cantidad de negativos.
            //Cantidad de ceros.
            //Cantidad de números pares.
            //Promedio de positivos.
            //Promedio de negativos.
            //Diferencia entre positivos y negativos, (positivos - negativos).
            //El número máximo
            //De los negativos el mínimo
            var rng = new Random();
            int number0;
            int negativos = 0;
            int positivos = 0;
            int cantPositivos = 0;
            int cantNegativos = 0;
            int cantZeros = 0;
            int cantPares = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int diferenciaPositivosNegativos = 0;
            int min = 0;
            int max = 0;


            for(int i = 0; i < 15; i++)
            {
                number0 = rng.Next(-100, 100);
                Console.WriteLine(number0);
                //number0 = int.Parse(Console.ReadLine());
                if (number0 < 0)
                {
                    negativos += number0;
                    cantNegativos++;
                }
                else
                {
                    if(number0 > 0)
                    {
                        positivos += number0;
                        cantPositivos++;
                    }
                    else
                    {
                        cantZeros++;
                    }
                }
                if(number0 % 2 == 0)
                {
                    cantPares++;
                }
                if (number0 < min && number0 < 0)
                {
                    min = number0;
                }
                if(number0 > max && number0 > 0)
                {
                    max = number0;
                }
            }
            if(cantNegativos != 0)
            {
                promedioNegativos = negativos / cantNegativos;
            }
            if(cantPositivos != 0)
            {
                promedioPositivos = positivos / cantPositivos;
            }
            promedioPositivos = positivos / cantPositivos;
            diferenciaPositivosNegativos = positivos + negativos;

            Console.WriteLine($"La suma de todos los numeros negativos da: {negativos}");
            Console.WriteLine($"La suma de todos los numeros positivos da: {positivos}");
            Console.WriteLine($"La cantidad de numeros positivos fue de: {cantPositivos}");
            Console.WriteLine($"La cantidad de numeros negativos fue de: {cantNegativos}");
            Console.WriteLine($"La cantidad de ceros ingresados fue de: {cantZeros}");
            Console.WriteLine($"La cantidad de numeros pares fue de: {cantPares}");
            Console.WriteLine($"El promedio de los numeros positivos es de: {promedioPositivos}");
            Console.WriteLine($"El promedio de los numeros negativos es de: {promedioNegativos}");
            Console.WriteLine($"La diferencia entre positivos y negativos es de: {diferenciaPositivosNegativos}");
            Console.WriteLine($"El numero maximo ingresado fue: {max}");
            Console.WriteLine($"El numero minimo ingresado fue: {min}");

        }
    }
}
