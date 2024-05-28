using System.Windows.Forms;

namespace WinFormEstudiante
{
    partial class FormularioEstudiante
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
            button_aceptar = new Button();
            button_limpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombre_texto = new TextBox();
            apellido_texto = new TextBox();
            lista_estudiantes = new ListBox();
            btn_mostrar = new Button();
            legajo_texto = new TextBox();
            SuspendLayout();
            // 
            // button_aceptar
            // 
            button_aceptar.Font = new Font("Arial", 12F, FontStyle.Bold);
            button_aceptar.Location = new Point(12, 204);
            button_aceptar.Name = "button_aceptar";
            button_aceptar.Size = new Size(83, 35);
            button_aceptar.TabIndex = 3;
            button_aceptar.Text = "Aceptar";
            button_aceptar.UseVisualStyleBackColor = true;
            button_aceptar.Click += button_aceptar_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Font = new Font("Arial", 12F, FontStyle.Bold);
            button_limpiar.Location = new Point(770, 316);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(91, 35);
            button_limpiar.TabIndex = 4;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 4;
            label3.Text = "Legajo";
            // 
            // nombre_texto
            // 
            nombre_texto.Font = new Font("Arial", 12F, FontStyle.Bold);
            nombre_texto.Location = new Point(12, 43);
            nombre_texto.Name = "nombre_texto";
            nombre_texto.Size = new Size(147, 26);
            nombre_texto.TabIndex = 0;
            // 
            // apellido_texto
            // 
            apellido_texto.Font = new Font("Arial", 12F, FontStyle.Bold);
            apellido_texto.Location = new Point(12, 94);
            apellido_texto.Name = "apellido_texto";
            apellido_texto.Size = new Size(147, 26);
            apellido_texto.TabIndex = 1;
            // 
            // lista_estudiantes
            // 
            lista_estudiantes.BackColor = SystemColors.HotTrack;
            lista_estudiantes.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lista_estudiantes.ForeColor = Color.Yellow;
            lista_estudiantes.FormattingEnabled = true;
            lista_estudiantes.HorizontalExtent = 1250;
            lista_estudiantes.HorizontalScrollbar = true;
            lista_estudiantes.ItemHeight = 23;
            lista_estudiantes.Location = new Point(252, 21);
            lista_estudiantes.Name = "lista_estudiantes";
            lista_estudiantes.SelectionMode = SelectionMode.None;
            lista_estudiantes.Size = new Size(696, 280);
            lista_estudiantes.TabIndex = 9;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_mostrar.Location = new Point(355, 316);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(91, 35);
            btn_mostrar.TabIndex = 10;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // legajo_texto
            // 
            legajo_texto.Font = new Font("Arial", 12F, FontStyle.Bold);
            legajo_texto.ForeColor = SystemColors.WindowText;
            legajo_texto.Location = new Point(12, 145);
            legajo_texto.Name = "legajo_texto";
            legajo_texto.Size = new Size(147, 26);
            legajo_texto.TabIndex = 2;
            // 
            // FormularioEstudiante
            // 
            AcceptButton = button_aceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1020, 372);
            Controls.Add(legajo_texto);
            Controls.Add(btn_mostrar);
            Controls.Add(lista_estudiantes);
            Controls.Add(apellido_texto);
            Controls.Add(nombre_texto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_limpiar);
            Controls.Add(button_aceptar);
            ForeColor = SystemColors.ControlText;
            Name = "FormularioEstudiante";
            Text = "Formulario de alumnos";
            Load += FormularioEstudiante_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_aceptar;
        private Button button_limpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombre_texto;
        private TextBox apellido_texto;
        private ListBox lista_estudiantes;
        private Button btn_mostrar;
        private TextBox legajo_texto;
    }
}