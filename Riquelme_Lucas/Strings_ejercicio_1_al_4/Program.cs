namespace Strings_ejercicio_1_al_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              
             
            //Ejercicio 01 de Strings

            string palabra;
            
            do
            {
                Console.WriteLine("Ingrese una palabra con mas de 5 caracteres: ");
                palabra = Console.ReadLine();
            } while (palabra.Length < 5);
            for(int i = 0; i < 3; i++)
            {
                Console.Write(palabra[i]);
            }

            */

            /*
             
             
            //Ejercicio 02 de Strings

            string palabra;
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();
            for(int i = 0;i < palabra.Length;i++)
            {
                Console.Write(palabra[i]);
                if (i < palabra.Length -1)
                {
                    Console.Write("-");
                }
            }

            */

            /*
              
             
            //Ejercicio 03 de Strings

            string palabra;
            string palabraModificada = String.Empty;

            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();

            foreach (char letra in palabra)
            {
                if (letra == 'a')
                {
                    palabraModificada += '$';
                }
                else
                {
                    palabraModificada += letra;
                }
            }
            Console.WriteLine(palabraModificada);

            */

            //Ejercicio 04 de Strings

            string palabra;
            string palabraModificada = String.Empty;

            palabra = "0000001234500000000";

            foreach (char letra in palabra)
            {
                if (letra != '0')
                {
                    palabraModificada += letra;
                }
            }
            Console.WriteLine(palabraModificada);

        }
    }
}
