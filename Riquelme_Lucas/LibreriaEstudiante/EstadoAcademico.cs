using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEstudiante
{
    public class EstadoAcademico
    {
        private Estudiante estudiante;
        private string carrera;
        private List<Materia> materias;

        private EstadoAcademico() 
        {
            materias = new List<Materia>();
        }
        public EstadoAcademico(Estudiante estudiante, string carrera) : this()
        {
            this.estudiante = estudiante;
            this.carrera = carrera;
        }

        public Materia SetMateria 
        {
            set 
            {
                materias.Add(value); 
            }
        }

    }
}
