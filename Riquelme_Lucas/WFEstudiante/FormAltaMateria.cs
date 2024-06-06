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
    public partial class FormAltaMateria : Form
    {

        private Materia miMateria;
        public Materia MiMateria {get { return this.miMateria;}}

        public FormAltaMateria()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_materia.Text))
            {
                this.miMateria = new Materia(txt_materia.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}
