using LibreriaProyectoEmpleados;

namespace ConsolaProyectoEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Proyecto A", "Proyecto B", "Proyecto C" };

            Empleado gerente = new Gerente("Pedro", 100, "Sistemas", 38, 50);
            Empleado desarrollador = new Desarrollador("Juan", 100, "Analitics", 2, "C#", "Trainee");
            Empleado analista = new Analista("Carolina", 100, "Compras", 10, "Ventas", list);
            
            List<Empleado> listaEmpleados = new List<Empleado>(){gerente,desarrollador,analista};

            foreach (Empleado empleado in listaEmpleados)
            {
                Console.WriteLine(empleado.Trabajar());
                Console.WriteLine(empleado.MostrarInfo());
                Console.WriteLine($"Salario total: ${empleado.SalarioTotal()}");
                Console.WriteLine($"Bonificacion: ${empleado.CalcularBonificacion()}\n");
            }
            Console.WriteLine(((Gerente)gerente).Planificar());
            Console.WriteLine(((Desarrollador)desarrollador).DepurarCodigo());
            Console.WriteLine(((Analista)analista).PrepararInforme());










            /*   IGNORAR, SON OTRAS OPCIONES QUE FUI PROBANDO
            Console.WriteLine(gerente.Trabajar());               
            Console.WriteLine(desarrollador.Trabajar());            
            Console.WriteLine(analista.Trabajar() + "\n");
             
            Console.WriteLine(gerente.MostrarInfo());            
            Console.WriteLine(desarrollador.MostrarInfo());
             
            Console.WriteLine(analista.MostrarInfo() + "\n");
           
            Console.WriteLine("Salario total gerente: $" + gerente.SalarioTotal());            
            Console.WriteLine("Salario total desarrollador: $" + desarrollador.SalarioTotal());            
            Console.WriteLine("Salario total analista: $" + analista.SalarioTotal() + "\n");
              
            Console.WriteLine("$" + gerente.CalcularBonificacion());             
            Console.WriteLine("$" + desarrollador.CalcularBonificacion());             
            Console.WriteLine("$" + analista.CalcularBonificacion() + "\n");
             

            */
            /*switch (empleado)
            {
                case Gerente variableTemporal:
                    Console.WriteLine(variableTemporal.Planificar() + "\n");
                    break;
                case Desarrollador variableTemporal:
                    Console.WriteLine(variableTemporal.DepurarCodigo() + "\n");
                    break;
                case Analista variableTemporal:
                    Console.WriteLine(variableTemporal.PrepararInforme() + "\n");
                    break;
            }*/

        }
    }
}
