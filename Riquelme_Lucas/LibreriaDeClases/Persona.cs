using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeClases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string documento;

        public Persona(string nombre, string apellido, int edad, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.documento = documento;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string SetNombre(string nuevoNombre)
        {
            return nombre = nuevoNombre;
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get;
            set;
        }
        public string Documento
        {   
            get;
        }

        public void Saludar()
        {
            Console.WriteLine($"¡Hola! Mi nombre es {nombre} y tengo {edad} años.");
        }
        
        public bool EsMayorDeEdad()
        {
            int edadMinima = 18;
            if(edad >= edadMinima)
            {
                Console.WriteLine($"{nombre} es mayor de edad");
                return true;
            }
            else
            {
                Console.WriteLine($"{nombre} es menor de edad");
                return false;
            }
        } 
    }
}
