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

namespace WinFormEstudiante
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("John", "Doe", "A123"),
                new Estudiante("Jane", "Smith", "B456"),
                new Estudiante("Bill", "Johnson", "C789"),
            };
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            dgv_estudiantes.DataSource = estudiantes;

        }
        
    }
}
