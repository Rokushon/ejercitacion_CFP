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

namespace WinFormPrincipalLapicera
{
    public partial class FormAltaLapicera : Form
    {
        Lapicera lapicera;
        List<Color> colors;
        public Lapicera Lapicera { get { return lapicera; } }

        public FormAltaLapicera()
        {
            InitializeComponent();
        }

        private void FormAltaLapicera_Load(object sender, EventArgs e)
        {
            colors = new List<Color>() {Color.Brown,Color.Aqua,Color.Red,Color.Blue,Color.Purple,Color.Violet };
            lb_colores.DataSource = colors;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string marca = getMarca();
            Color color = (Color)lb_colores.SelectedItem;
            int precio = (int)num_precio.Value;
            lapicera = new Lapicera(color,precio,marca);
            DialogResult = DialogResult.OK;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private string getMarca()
        {
            string marca = "";
            foreach (RadioButton rd in gb_marcas.Controls)
            {
                if (rd.Checked)
                {
                    marca = rd.Text;
                    break;
                }
            }
            return marca;
        }
    }
}
