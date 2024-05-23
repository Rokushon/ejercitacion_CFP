namespace FormularioPrueba
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            button_aceptar = new Button();
            button_limpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            marca_texto = new TextBox();
            combustible_texto = new TextBox();
            lst_misAutos = new ListBox();
            combo_box = new ComboBox();
            btn_mostrar = new Button();
            SuspendLayout();
            // 
            // button_aceptar
            // 
            button_aceptar.Font = new Font("Arial", 12F, FontStyle.Bold);
            button_aceptar.Location = new Point(12, 231);
            button_aceptar.Name = "button_aceptar";
            button_aceptar.Size = new Size(83, 35);
            button_aceptar.TabIndex = 3;
            button_aceptar.Text = "Aceptar";
            button_aceptar.UseVisualStyleBackColor = true;
            button_aceptar.Click += boton_aceptar;
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
            label1.Size = new Size(55, 19);
            label1.TabIndex = 2;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(147, 19);
            label2.TabIndex = 3;
            label2.Text = "Cant. combustible";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 4;
            label3.Text = "Color";
            // 
            // marca_texto
            // 
            marca_texto.Font = new Font("Arial", 12F, FontStyle.Bold);
            marca_texto.Location = new Point(12, 43);
            marca_texto.Name = "marca_texto";
            marca_texto.Size = new Size(147, 26);
            marca_texto.TabIndex = 0;
            // 
            // combustible_texto
            // 
            combustible_texto.Font = new Font("Arial", 12F, FontStyle.Bold);
            combustible_texto.Location = new Point(12, 104);
            combustible_texto.Name = "combustible_texto";
            combustible_texto.Size = new Size(147, 26);
            combustible_texto.TabIndex = 1;
            // 
            // lst_misAutos
            // 
            lst_misAutos.BackColor = SystemColors.HotTrack;
            lst_misAutos.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lst_misAutos.ForeColor = Color.Yellow;
            lst_misAutos.FormattingEnabled = true;
            lst_misAutos.ItemHeight = 23;
            lst_misAutos.Location = new Point(278, 21);
            lst_misAutos.Name = "lst_misAutos";
            lst_misAutos.SelectionMode = SelectionMode.None;
            lst_misAutos.Size = new Size(700, 280);
            lst_misAutos.TabIndex = 9;
            // 
            // combo_box
            // 
            combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_box.Font = new Font("Arial", 12F, FontStyle.Bold);
            combo_box.FormattingEnabled = true;
            combo_box.Location = new Point(12, 171);
            combo_box.Name = "combo_box";
            combo_box.Size = new Size(147, 27);
            combo_box.TabIndex = 2;
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
            // Formulario
            // 
            AcceptButton = button_aceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1020, 372);
            Controls.Add(btn_mostrar);
            Controls.Add(combo_box);
            Controls.Add(lst_misAutos);
            Controls.Add(combustible_texto);
            Controls.Add(marca_texto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_limpiar);
            Controls.Add(button_aceptar);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Formulario";
            Text = "Formulario de autos";
            Load += Formulario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_aceptar;
        private Button button_limpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox marca_texto;
        private TextBox combustible_texto;
        private ListBox lst_misAutos;
        private ComboBox combo_box;
        private Button btn_mostrar;
    }
}
