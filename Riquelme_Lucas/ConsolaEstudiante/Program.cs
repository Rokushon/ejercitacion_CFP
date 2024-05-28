using LibreriaEstudiante;

namespace ConsolaEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante Lucas = new Estudiante("Lucas", "Riquelme", "5201");
            Estudiante Josefina = new Estudiante("Josefina", "Josefa", "4444");
            Estudiante Test3 = new Estudiante("Test", "3", "6600");

            Lucas.SetNotaPrimerParcial(2);
            Josefina.SetNotaPrimerParcial(4);
            Test3.SetNotaPrimerParcial(8);

            Lucas.SetNotaSegundoParcial(10);
            Josefina.SetNotaSegundoParcial(4);
            Test3.SetNotaSegundoParcial(4);

            Console.WriteLine(Lucas.Mostrar());
            Console.WriteLine(Josefina.Mostrar());
            Console.WriteLine(Test3.Mostrar());
        }
    }
}
