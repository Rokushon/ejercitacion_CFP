namespace WFEstudiante
{
    partial class FormAltaMateria
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
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            txt_materia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(12, 100);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 1;
            btn_aceptar.Text = "aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(127, 100);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += this.btn_cancelar_Click;
            // 
            // txt_materia
            // 
            txt_materia.Location = new Point(102, 36);
            txt_materia.Name = "txt_materia";
            txt_materia.Size = new Size(100, 23);
            txt_materia.TabIndex = 3;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 192);
            Controls.Add(txt_materia);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(label1);
            Name = "FormAltaMateria";
            Text = "FormAltaMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_aceptar;
        private Button btn_cancelar;
        private TextBox txt_materia;
    }
}