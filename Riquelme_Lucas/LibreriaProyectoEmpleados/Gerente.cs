using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyectoEmpleados
{
    public class Gerente : Empleado
    {
        int numeroEmpleados;

        public Gerente(string nombre, double salario, string departamento, int antiguedad,int numeroEmpleados)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.numeroEmpleados = numeroEmpleados;
        }
        public override string Trabajar()
        {
            return "El gerente está gestionando el departamento.";
        }
        public override double CalcularBonificacion()
        {
            return this.salario * 0.25;
        }

        public string Planificar()
        {
            return $"Creando una planificacion para {numeroEmpleados} empleados.";
        }

        public override double SalarioTotal()
        {
            return this.salario + CalcularBonificacion();
        }
    }
}
