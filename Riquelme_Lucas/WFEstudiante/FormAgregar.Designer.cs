namespace WFEstudiante
{
    partial class FormAgregar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btn_aceptar = new Button();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_legajo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 162);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Legajo";
            // 
            // button1
            // 
            button1.Location = new Point(165, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(24, 253);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 4;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(24, 62);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 5;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(24, 122);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 6;
            // 
            // txt_legajo
            // 
            txt_legajo.Location = new Point(24, 180);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(100, 23);
            txt_legajo.TabIndex = 7;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 351);
            Controls.Add(txt_legajo);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(btn_aceptar);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregar";
            Text = "Nuevo Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btn_aceptar;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_legajo;
    }
}