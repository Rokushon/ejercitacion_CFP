using LibreriaEstudiante;

namespace WFEstudiante
{
    public partial class FormPrincipal : Form
    {
        List<Estudiante> estudiantes;
        List<Materia> materias;
        Random rnd;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.rnd = new Random();
            this.materias = new List<Materia>();

            this.estudiantes = new List<Estudiante>()
            {
                new Estudiante ("Lucas","Domingo","LPM001"),
                new Estudiante ("John", "Doe", "JD123"),
                new Estudiante ("Jane", "Smith", "JS456"),
                new Estudiante ("Bill", "Johnson", "BJ789"),
            };
            //this.dgv_estudiantes.CellFormatting += Dgv_estudiantes_CellFormatting;

        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //this.dgv_estudiantes.DataSource = null;
            //this.dgv_estudiantes.DataSource = estudiantes;

            this.lb_estudiantes.Items.Clear();
            this.lb_estudiantes.Items.AddRange(estudiantes.ToArray());
        }
        private void btn_evaluar_Click(object sender, EventArgs e)
        {
            //    foreach (Estudiante estudiante in estudiantes)
            //    {
            //        estudiante.NotaPrimerParcial = rnd.Next(1, 11);
            //        estudiante.NotaSegundoParcial = (rnd.Next(1, 11));
            //    }
            //    dgv_estudiantes.Refresh();
        }
        //private void Dgv_estudiantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dgv_estudiantes.Columns[e.ColumnIndex].Name.Equals("NotaFinal"))
        //    {

        //        if (e.Value is not null && (double)e.Value == -1)
        //        {
        //            e.Value = "Alumno desaprobado";

        //        }
        //    }
        //}

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            using (FormAgregar formulario = new FormAgregar())
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    this.estudiantes.Add(formulario.Juancito);
                    //this.estudiantes.Add(formulario.Juancito2()); tambien se comunica con el formulario agregar.
                }
            }
        }
        private void agregar_materia_Click(object sender, EventArgs e)
        {
            FormAltaMateria formAltaMateria = new FormAltaMateria();
            formAltaMateria.ShowDialog();
            if (formAltaMateria.DialogResult == DialogResult.OK)
            {
                materias.Add(formAltaMateria.MiMateria);
                this.lb_materias.Items.Clear();
                lb_materias.Items.AddRange(materias.ToArray());
                this.lb_estudiantes.Items.Clear();
                this.lb_estudiantes.Items.AddRange(estudiantes.ToArray());
            }
        }

        private void btn_estado_academico_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = estudiantes[0];
            List<Materia> lista = materias;
            string carrera = "jaja";
            FormEstadoAcademico estadoAcademico = new FormEstadoAcademico(estudiante,lista,carrera);
            estadoAcademico.ShowDialog();
        }
    }
}
