using LibreriaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRegistrate
{
    public partial class FormAlta : Form
    {
        Ingresante ingresante;

        public Ingresante Ingresante { get => ingresante;}

        public FormAlta()
        {
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            lb_paises.DataSource = new List<string>()
            {
                "Argentina","Colombia","Uruguay","Ecuador","Chile","Cuba"
            };
        }
        private void btn_agregar2_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            int edad = (int)numeric_value.Value;
            string genero = string.Empty;
            string pais = lb_paises.SelectedItem.ToString();
            List<string> cursos = new List<string>();

            //transformar a metodos
            foreach(RadioButton rd in gb_genero.Controls)
            {
                if(rd.Checked)
                {
                    genero = rd.Text;
                    break;
                }
            }
            foreach(CheckBox cb in gb_cursos.Controls)
            {
                if(cb.Checked)
                {
                    cursos.Add(cb.Text);
                }
            }
            ingresante = new Ingresante(nombre,apellido,edad,genero,pais,cursos);
            DialogResult = DialogResult.OK;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
