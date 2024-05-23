using LibreriaClaseEvaluacion;

namespace ConsolaEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repeticiones = 0;

            Auto fiatPalio = new Auto("Fiat",10,"Rojo");
            Console.WriteLine(fiatPalio.AutoToString());
            while (fiatPalio.Avanzar(8)) 
            {
                repeticiones++;
            }
            Console.WriteLine("Logro realizar " + repeticiones + " repeticiones");

            
        }
    }
}
