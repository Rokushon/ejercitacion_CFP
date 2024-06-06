using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEstudiante
{
    public class Materia
    {
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rnd;

        public string Nombre { get => nombre;}
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
        public int NotaFinal
        {
            get 
            {
                return CalcularNotaFinal(); 
            }
        }
        public double Promedio 
        {
            get 
            {
                return CalcularPromedio(); 
            } 
        }

        static Materia()
        {
            rnd = new Random();
        }
        public Materia (string nombre)
        {
            this.nombre = nombre;
        }

        private int CalcularNotaFinal()
        {
            int nota = 0;
            if (notaPrimerParcial > 3 && notaSegundoParcial > 3)
            {
                nota = rnd.Next(6, 11);
            }
            return nota;
        }
        private double CalcularPromedio()
        {
            return ((double)NotaPrimerParcial + NotaSegundoParcial) / 2;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
