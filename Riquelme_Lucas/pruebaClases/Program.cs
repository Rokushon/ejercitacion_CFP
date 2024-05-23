using LibreriaDeClases;


namespace pruebaClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lucas","Riquelme",27,"44446622");
            Persona persona2 = new Persona("Juan", "Suarez", 17, "69966221");
            Persona persona3 = new Persona("Manuel", "Rosas", 18, "66632122");
            Persona persona4 = new Persona("Melisa", "Melinda", 48, "62661622");
            Persona persona5 = new Persona("Yanina", "Yaz", 15, "12956622");

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(persona1);
            listaPersonas.Add(persona2);
            listaPersonas.Add(persona3);
            listaPersonas.Add(persona4);
            listaPersonas.Add(persona5);

            persona2.Saludar();
            persona2.EsMayorDeEdad();

            Console.WriteLine(persona2.Apellido);
            Console.WriteLine(persona2.Apellido = "Ramon");

            foreach (Persona persona in listaPersonas)
            {
                Console.Write(persona.GetNombre());
                Console.Write(" ");
                Console.WriteLine(persona.Apellido);
            }
        }
    }
}
