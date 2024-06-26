using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyectoEmpleados
{
    public class Analista : Empleado
    {
        string especialidad;
        List<string> proyectos;

        public Analista(string nombre, double salario, string departamento, int antiguedad,string especialidad, List<string> proyectos) 
            : base(nombre, salario, departamento, antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;
        }
        public override string Trabajar()
        {
            return "El analista está analizando los datos.";
        }

        public override double CalcularBonificacion()
        {
            return this.salario * 0.10;
        }

        public string PrepararInforme()
        {
            return $"El analista esta preparando los informes de sus proyectos: {string.Join(" - ", proyectos)}";
        }

        public override double SalarioTotal()
        {
            return this.salario + CalcularBonificacion();
        }
    }
}
