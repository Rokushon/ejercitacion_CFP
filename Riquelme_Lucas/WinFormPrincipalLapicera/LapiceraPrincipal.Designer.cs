namespace WinFormPrincipalLapicera
{
    partial class LapiceraPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapiceraPrincipal));
            dgv_lapicera = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lapicera).BeginInit();
            SuspendLayout();
            // 
            // dgv_lapicera
            // 
            dgv_lapicera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lapicera.BackgroundColor = SystemColors.ControlDarkDark;
            dgv_lapicera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lapicera.Location = new Point(13, 13);
            dgv_lapicera.Margin = new Padding(4);
            dgv_lapicera.Name = "dgv_lapicera";
            dgv_lapicera.Size = new Size(1383, 542);
            dgv_lapicera.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(605, 564);
            btn_agregar.Margin = new Padding(4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(154, 50);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // LapiceraPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1420, 627);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_lapicera);
            Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LapiceraPrincipal";
            Text = "Lista de lapiceras creadas";
            Load += LapiceraPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_lapicera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_lapicera;
        private Button btn_agregar;
    }
}
