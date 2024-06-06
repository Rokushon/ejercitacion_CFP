using LibreriaEstudiante;

namespace ConsolaEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante("Lucas", "Riquelme", "5201"),
                new Estudiante("Josefina", "Josefa", "4444"),
                new Estudiante("Test", "3", "6600"),
            };

            foreach(Estudiante estudiante in estudiantes)
            {
                estudiante.SetNotaPrimerParcial(rnd.Next(1, 11));
                estudiante.SetNotaSegundoParcial(rnd.Next(1, 11));
            }
            foreach(Estudiante mostrarEstudiante in estudiantes)
            {
                Console.WriteLine(mostrarEstudiante.Mostrar());
            }           
        }
    }
}
