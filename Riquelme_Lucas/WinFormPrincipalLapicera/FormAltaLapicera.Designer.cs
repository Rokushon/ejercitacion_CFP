namespace WinFormPrincipalLapicera
{
    partial class FormAltaLapicera
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
            gb_marcas = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lb_colores = new ListBox();
            Colores = new Label();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            num_precio = new NumericUpDown();
            label2 = new Label();
            gb_marcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            SuspendLayout();
            // 
            // gb_marcas
            // 
            gb_marcas.Controls.Add(radioButton3);
            gb_marcas.Controls.Add(radioButton2);
            gb_marcas.Controls.Add(radioButton1);
            gb_marcas.Location = new Point(30, 29);
            gb_marcas.Margin = new Padding(4);
            gb_marcas.Name = "gb_marcas";
            gb_marcas.Padding = new Padding(4);
            gb_marcas.Size = new Size(131, 155);
            gb_marcas.TabIndex = 0;
            gb_marcas.TabStop = false;
            gb_marcas.Text = "Marcas";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(9, 101);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Conklin";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(9, 66);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pelikan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(9, 31);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Bic";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // lb_colores
            // 
            lb_colores.FormattingEnabled = true;
            lb_colores.ItemHeight = 21;
            lb_colores.Location = new Point(30, 222);
            lb_colores.Margin = new Padding(4);
            lb_colores.Name = "lb_colores";
            lb_colores.Size = new Size(280, 172);
            lb_colores.TabIndex = 3;
            // 
            // Colores
            // 
            Colores.AutoSize = true;
            Colores.Location = new Point(30, 197);
            Colores.Margin = new Padding(4, 0, 4, 0);
            Colores.Name = "Colores";
            Colores.Size = new Size(67, 21);
            Colores.TabIndex = 4;
            Colores.Text = "Colores";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(203, 402);
            btn_cancelar.Margin = new Padding(4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(107, 32);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(30, 402);
            btn_aceptar.Margin = new Padding(4);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(107, 32);
            btn_aceptar.TabIndex = 5;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // num_precio
            // 
            num_precio.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            num_precio.Location = new Point(181, 60);
            num_precio.Margin = new Padding(4);
            num_precio.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(129, 28);
            num_precio.TabIndex = 4;
            num_precio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 8;
            label2.Text = "Precio";
            // 
            // FormAltaLapicera
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(334, 455);
            Controls.Add(label2);
            Controls.Add(num_precio);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(Colores);
            Controls.Add(lb_colores);
            Controls.Add(gb_marcas);
            Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold);
            ForeColor = SystemColors.WindowText;
            Margin = new Padding(4);
            Name = "FormAltaLapicera";
            Text = "La Mejor Lapicera";
            Load += FormAltaLapicera_Load;
            gb_marcas.ResumeLayout(false);
            gb_marcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_marcas;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListBox lb_colores;
        private Label Colores;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private NumericUpDown num_precio;
        private Label label2;
    }
}