namespace LibreriaProyectoEmpleados
{
    public abstract class Empleado
    {
        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        protected Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public abstract string Trabajar();
        public virtual string MostrarInfo() 
        {
            return $"Nombre: {nombre}\nSalario: ${salario}\nDepartamento: {departamento}\nAntiguedad: {antiguedad} meses";
        }
        public virtual double CalcularBonificacion() 
        {
            return 0 ;
        }
        public abstract double SalarioTotal(); //retorna la informacion de la suma del sueldo mas el valor de la bonificacion
    }
}
