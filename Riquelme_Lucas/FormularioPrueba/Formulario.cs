using LibreriaClaseEvaluacion;
using LibreriaDeFunciones;
#nullable disable

namespace FormularioPrueba
{
    public partial class Formulario : Form
    {
        List<Auto> misAutos;
        bool bandera;

        public Formulario()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            //combo_box.Items.AddRange(Auto.ColoresElegidos());
            this.misAutos = new List<Auto>();
            foreach (Color color in Auto.ColoresElegidos())
            {
                combo_box.Items.Add(color.Name);
            }
            combo_box.SelectedIndex = 0;
        }

        private void boton_aceptar(object sender, EventArgs e)
        {
            string marca = this.marca_texto.Text;
            string cantidad = this.combustible_texto.Text;
            Color color = Color.FromName(this.combo_box.Text);
            bandera = true;

            if (MisFunciones.IsEmpty(marca))
            {
                MessageBox.Show("No pusiste la marca");
                bandera = false;
            }
            if (MisFunciones.IsString(marca))
            {
                MessageBox.Show("La marca no puede contener numeros");
                bandera = false;
            }
            if (MisFunciones.IsNumber(cantidad))
            {
                MessageBox.Show("La cantidad debe ser un numero entero");
                bandera = false;
            }
            if (MisFunciones.IsEmpty(cantidad))
            {
                MessageBox.Show("No pusiste la cantidad de combustible");
                bandera = false;
            }

            if (bandera)
            {
                switch (MessageBox.Show("Desea agregar este auto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Auto auto = new Auto(marca, cantidad, color); // se crea el auto aca si el usuario da el OK
                        misAutos.Add(auto);
                        this.lst_misAutos.Items.Add(auto.AutoToString()); //para poner auto x auto
                        this.Limpiar();
                        break;

                    case DialogResult.No:
                        MessageBox.Show("Auto no agregado");
                        break;
                }
            }
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.Vaciarlista();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.Vaciarlista();
            this.lst_misAutos.Items.AddRange(misAutos.ToArray());
        }
        private void Vaciarlista()
        {
            lst_misAutos.Items.Clear();
        }
        private void Limpiar()
        {
            marca_texto.Text = string.Empty;
            combustible_texto.Text = string.Empty;
            //combo_box.Text = string.Empty; no sirve asi que lo cambie por null
            combo_box.SelectedItem = null;
        }
    }
}
