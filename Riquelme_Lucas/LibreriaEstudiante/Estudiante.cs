using System.Text;

namespace LibreriaEstudiante
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }
        private double CalcularPromedio()
        {
            return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            int notaFinal = -1;
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6,11);
            }
            return notaFinal;
        }
        public string Mostrar()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($" Nombre: {nombre} ;");
            informacion.AppendLine($" Apellido: {apellido} ;");
            informacion.AppendLine($" Numero de legajo: {legajo} ;");
            informacion.AppendLine($" Primer parcial: {notaPrimerParcial} ;");
            informacion.AppendLine($" Segundo parcial: {notaSegundoParcial} ;");
            informacion.AppendLine($" Promedio: {CalcularPromedio()} ;");
            informacion.AppendLine(MostrarNotaFinal());
            return informacion.ToString();
        }

        private string MostrarNotaFinal()
        {
            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1) 
            {
                return $" Nota final: {notaFinal} ;";
            }
            else
            {
                return " Alumno desaprobado ;";
            }
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
