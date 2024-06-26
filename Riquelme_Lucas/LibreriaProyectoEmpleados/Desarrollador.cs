using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProyectoEmpleados
{
    public class Desarrollador : Empleado
    {
        string lenguajeProgramacion;
        string experiencia;

        public Desarrollador(string nombre, double salario, string departamento, int antiguedad,string lenguajeProgramacion,string experiencia) 
            : base(nombre, salario, departamento, antiguedad)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.experiencia = experiencia;
        }

        public override string Trabajar()
        {
            return "El desarrollador está escribiendo código.";
        }

        public override double CalcularBonificacion()
        {
            return this.salario * 0.15;
        }

        public string DepurarCodigo()
        {
            return $"Depurando codigo en el lenguaje de programacion {lenguajeProgramacion}";
        }

        public override double SalarioTotal()
        {
            return this.salario + CalcularBonificacion();
        }
    }
}
