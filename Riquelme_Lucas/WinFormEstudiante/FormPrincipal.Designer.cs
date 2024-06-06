namespace WinFormEstudiante
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_estudiantes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            lista_estudiantes = new ListBox();
            btn_mostrar = new Button();
            btn_evaluar = new Button();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_estudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgv_estudiantes
            // 
            dgv_estudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_estudiantes.Location = new Point(421, 42);
            dgv_estudiantes.Margin = new Padding(5);
            dgv_estudiantes.Name = "dgv_estudiantes";
            dgv_estudiantes.Size = new Size(678, 395);
            dgv_estudiantes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label1.Location = new Point(39, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 1;
            label1.Text = "Estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 14);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 2;
            label2.Text = "Planilla de Notas";
            // 
            // lista_estudiantes
            // 
            lista_estudiantes.FormattingEnabled = true;
            lista_estudiantes.ItemHeight = 23;
            lista_estudiantes.Location = new Point(39, 42);
            lista_estudiantes.Margin = new Padding(5);
            lista_estudiantes.Name = "lista_estudiantes";
            lista_estudiantes.Size = new Size(300, 395);
            lista_estudiantes.TabIndex = 3;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(930, 477);
            btn_mostrar.Margin = new Padding(5);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(118, 35);
            btn_mostrar.TabIndex = 4;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += this.btn_mostrar_Click;
            // 
            // btn_evaluar
            // 
            btn_evaluar.Location = new Point(462, 477);
            btn_evaluar.Margin = new Padding(5);
            btn_evaluar.Name = "btn_evaluar";
            btn_evaluar.Size = new Size(118, 35);
            btn_evaluar.TabIndex = 5;
            btn_evaluar.Text = "Evaluar";
            btn_evaluar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(48, 477);
            btn_agregar.Margin = new Padding(5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(118, 35);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 568);
            Controls.Add(btn_agregar);
            Controls.Add(btn_evaluar);
            Controls.Add(btn_mostrar);
            Controls.Add(lista_estudiantes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_estudiantes);
            Font = new Font("Arial Black", 12F, FontStyle.Bold);
            Margin = new Padding(5);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_estudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_estudiantes;
        private Label label1;
        private Label label2;
        private ListBox lista_estudiantes;
        private Button btn_mostrar;
        private Button btn_evaluar;
        private Button btn_agregar;
    }
}