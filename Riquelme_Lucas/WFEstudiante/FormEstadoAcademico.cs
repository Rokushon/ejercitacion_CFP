using LibreriaEstudiante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEstudiante
{
    public partial class FormEstadoAcademico : Form
    {
        private Estudiante estudiante;
        private List<Materia> lsMaterias;
        private string carrera;

        public FormEstadoAcademico()
        {
            InitializeComponent();
        }
        public FormEstadoAcademico(Estudiante estudiante,List<Materia> lsMaterias,string carrera) :this()
        {
            this.estudiante = estudiante;
            this.lsMaterias = lsMaterias;
            this.carrera = carrera;
        }
        private void load(object s, EventArgs e)
        {
            Cargarlsb();
        }

        private void Cargarlsb()
        {
            listBox1.Items.Add(estudiante);
            listBox1.Items.Add($"Carrera: {carrera}");
            listBox1.Items.Add("Listado de materias:");

            foreach (Materia a in lsMaterias)
            {
                listBox1.Items.Add(a.Nombre);
            }
        }

    }
}
