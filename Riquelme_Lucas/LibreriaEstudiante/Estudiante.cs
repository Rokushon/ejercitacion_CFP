using System.Text;
using System.Transactions;

namespace LibreriaEstudiante
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;

        //private int notaPrimerParcial;
        //private int notaSegundoParcial;

        private static Random random;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Legajo { get => legajo; set => legajo = value; }


        //public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }

        //public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        //public double Promedio {
        //    get 
        //    {
        //        return CalcularPromedio();
        //    }
        //        }
        //public double NotaFinal
        //{
        //    get
        //    {
        //        return CalcularNotaFinal();
        //    }
        //}

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

        //public void SetNotaPrimerParcial(int nota)
        //{
        //    notaPrimerParcial = nota;
        //}
        //public void SetNotaSegundoParcial(int nota)
        //{
        //    notaSegundoParcial = nota;
        //}
        //private double CalcularPromedio()
        //{
        //    return ((double)notaPrimerParcial + notaSegundoParcial) / 2;
        //}

       /* public void PasarPromedio()
        {
            Promedio = CalcularPromedio();
        }*/

        //public double CalcularNotaFinal()
        //{
        //    int notaFinal = -1;
        //    if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
        //    {
        //        notaFinal = random.Next(6,11);
        //    }
        //    return notaFinal;
        //}

/*        public void PasarNotaFinal()
        {
            NotaFinal = CalcularNotaFinal();
        }
*/

        //public string Mostrar()
        //{
        //    StringBuilder informacion = new StringBuilder();
        //    informacion.AppendLine($" Nombre: {nombre} - " +$" Apellido: {apellido} - "+ $" Numero de legajo: {legajo} ;");
        //    informacion.Append($" Primer parcial: {notaPrimerParcial} - ");
        //    informacion.Append($" Segundo parcial: {notaSegundoParcial} - ");
        //    informacion.AppendLine($" Promedio: {CalcularPromedio()} ; ");
        //    informacion.AppendLine(MostrarNotaFinal());
        //    return informacion.ToString();
        //}

        //private string MostrarNotaFinal()
        //{
        //    double notaFinal = CalcularNotaFinal();
        //    if (notaFinal != -1) 
        //    {
        //        return $" Nota final: {notaFinal} ;";
        //    }
        //    else
        //    {
        //        return " Alumno desaprobado ;";
        //    }
        //}
        public override string ToString()
        {
            return $"{nombre}  {apellido}";
        }
    }
}
