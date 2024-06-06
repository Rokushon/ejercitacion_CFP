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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFEstudiante
{
    public partial class FormAgregar : Form
    {
        private Estudiante juancito;
        public Estudiante Juancito { get 
            {
                return juancito;
            }
        }
        public Estudiante Juancito2()
        {
            return Juancito;
        }
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            juancito = new Estudiante(txt_nombre.Text,txt_apellido.Text,txt_legajo.Text); 
            DialogResult = DialogResult.OK;
        }
    }
}
