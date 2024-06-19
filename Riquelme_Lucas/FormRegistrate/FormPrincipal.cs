using LibreriaDeClases;

namespace FormRegistrate
{
    public partial class FormPrincipal : Form
    {
        List<Ingresante> ingresantes;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ingresantes = new List<Ingresante>();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            if(formAlta.ShowDialog() == DialogResult.OK)
            {
                ingresantes.Add(formAlta.Ingresante);
                dgvCargar();

            }
        }
        private void dgvCargar()
        {
            dgv_ingresante.DataSource = null;
            dgv_ingresante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ingresante.DataSource = ingresantes;
        }
    }
}
