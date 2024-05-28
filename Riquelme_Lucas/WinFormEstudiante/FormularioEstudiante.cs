using LibreriaDeFunciones;
using LibreriaEstudiante;
using System.Reflection;
#nullable disable

namespace WinFormEstudiante
{
    public partial class FormularioEstudiante : Form
    {
        List<Estudiante> misEstudiantes;
        bool bandera;
        public FormularioEstudiante()
        {
            InitializeComponent();
        }
        private void FormularioEstudiante_Load_1(object sender, EventArgs e)
        {
            this.misEstudiantes = new List<Estudiante>();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.nombre_texto.Text;
            string apellido = this.apellido_texto.Text;
            string legajo = this.legajo_texto.Text;
            bandera = true;

            if (MisFunciones.IsEmpty(nombre))
            {
                MessageBox.Show("No ingresaste el nombre");
                bandera = false;
            }
            if (MisFunciones.IsEmpty(apellido))
            {
                MessageBox.Show("No ingresaste el apellido");
                bandera = false;
            }
            if (MisFunciones.IsEmpty(legajo))
            {
                MessageBox.Show("No ingresaste el legajo");
                bandera = false;
            }
            if (bandera)
            {
                switch (MessageBox.Show("Desea agregar este alumno?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Estudiante estudiante = new Estudiante(nombre, apellido, legajo);
                        misEstudiantes.Add(estudiante);
                        this.lista_estudiantes.Items.Add(estudiante.Mostrar());
                        this.Limpiar();
                        break;

                    case DialogResult.No:
                        MessageBox.Show("Alumno no agregado");
                        break;
                }
            }
        }
        private void Vaciarlista()
        {
            lista_estudiantes.Items.Clear();
        }
        private void Limpiar()
        {
            nombre_texto.Text = string.Empty;
            apellido_texto.Text = string.Empty;
            legajo_texto.Text = string.Empty;
        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            this.Vaciarlista();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.Vaciarlista();
            this.lista_estudiantes.Items.AddRange(misEstudiantes.ToArray());
        }
    }
}
