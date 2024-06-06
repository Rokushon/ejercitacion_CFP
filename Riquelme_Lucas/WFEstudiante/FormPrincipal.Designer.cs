namespace WFEstudiante
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            lb_estudiantes = new ListBox();
            agregar_materia = new Button();
            lb_materias = new ListBox();
            btn_estado_academico = new Button();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(30, 356);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(158, 23);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar alumno";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 18);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Materias";
            // 
            // lb_estudiantes
            // 
            lb_estudiantes.FormattingEnabled = true;
            lb_estudiantes.ItemHeight = 15;
            lb_estudiantes.Location = new Point(30, 46);
            lb_estudiantes.Name = "lb_estudiantes";
            lb_estudiantes.Size = new Size(158, 304);
            lb_estudiantes.TabIndex = 6;
            // 
            // agregar_materia
            // 
            agregar_materia.Location = new Point(221, 356);
            agregar_materia.Name = "agregar_materia";
            agregar_materia.Size = new Size(158, 23);
            agregar_materia.TabIndex = 7;
            agregar_materia.Text = "Agregar materia";
            agregar_materia.UseVisualStyleBackColor = true;
            agregar_materia.Click += agregar_materia_Click;
            // 
            // lb_materias
            // 
            lb_materias.FormattingEnabled = true;
            lb_materias.ItemHeight = 15;
            lb_materias.Location = new Point(221, 46);
            lb_materias.Name = "lb_materias";
            lb_materias.Size = new Size(158, 304);
            lb_materias.TabIndex = 8;
            // 
            // btn_estado_academico
            // 
            btn_estado_academico.Location = new Point(411, 356);
            btn_estado_academico.Name = "btn_estado_academico";
            btn_estado_academico.Size = new Size(158, 23);
            btn_estado_academico.TabIndex = 9;
            btn_estado_academico.Text = "Crear estado academico";
            btn_estado_academico.UseVisualStyleBackColor = true;
            btn_estado_academico.Click += btn_estado_academico_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 453);
            Controls.Add(btn_estado_academico);
            Controls.Add(lb_materias);
            Controls.Add(agregar_materia);
            Controls.Add(lb_estudiantes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Label label1;
        private Label label2;
        private ListBox lb_estudiantes;
        private Button agregar_materia;
        private ListBox lb_materias;
        private Button btn_estado_academico;
    }
}
