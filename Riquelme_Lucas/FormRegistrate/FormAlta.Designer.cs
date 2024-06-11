namespace FormRegistrate
{
    partial class FormAlta
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
            gb_datos = new GroupBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numeric_value = new NumericUpDown();
            gb_cursos = new GroupBox();
            cb_csharp = new CheckBox();
            cb_angular = new CheckBox();
            cb_python = new CheckBox();
            cb_node = new CheckBox();
            cb_javascript = new CheckBox();
            gb_genero = new GroupBox();
            rb_masculino = new RadioButton();
            rb_femenino = new RadioButton();
            rb_no_binario = new RadioButton();
            lb_paises = new ListBox();
            btn_cancelar = new Button();
            btn_agregar2 = new Button();
            label_pais = new Label();
            gb_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_value).BeginInit();
            gb_cursos.SuspendLayout();
            gb_genero.SuspendLayout();
            SuspendLayout();
            // 
            // gb_datos
            // 
            gb_datos.Controls.Add(txt_apellido);
            gb_datos.Controls.Add(txt_nombre);
            gb_datos.Controls.Add(label1);
            gb_datos.Controls.Add(label2);
            gb_datos.Controls.Add(label3);
            gb_datos.Controls.Add(numeric_value);
            gb_datos.Location = new Point(12, 12);
            gb_datos.Name = "gb_datos";
            gb_datos.Size = new Size(272, 192);
            gb_datos.TabIndex = 0;
            gb_datos.TabStop = false;
            gb_datos.Text = "Datos del ingresante";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(112, 99);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(120, 23);
            txt_apellido.TabIndex = 8;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(112, 50);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(120, 23);
            txt_nombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 99);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 148);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Edad";
            // 
            // numeric_value
            // 
            numeric_value.Location = new Point(112, 148);
            numeric_value.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numeric_value.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeric_value.Name = "numeric_value";
            numeric_value.Size = new Size(120, 23);
            numeric_value.TabIndex = 1;
            numeric_value.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gb_cursos
            // 
            gb_cursos.Controls.Add(cb_csharp);
            gb_cursos.Controls.Add(cb_angular);
            gb_cursos.Controls.Add(cb_python);
            gb_cursos.Controls.Add(cb_node);
            gb_cursos.Controls.Add(cb_javascript);
            gb_cursos.Location = new Point(348, 160);
            gb_cursos.Name = "gb_cursos";
            gb_cursos.Size = new Size(200, 161);
            gb_cursos.TabIndex = 0;
            gb_cursos.TabStop = false;
            gb_cursos.Text = "Cursos";
            // 
            // cb_csharp
            // 
            cb_csharp.AutoSize = true;
            cb_csharp.Location = new Point(11, 25);
            cb_csharp.Name = "cb_csharp";
            cb_csharp.Size = new Size(44, 19);
            cb_csharp.TabIndex = 4;
            cb_csharp.Text = "C #";
            cb_csharp.UseVisualStyleBackColor = true;
            // 
            // cb_angular
            // 
            cb_angular.AutoSize = true;
            cb_angular.Location = new Point(11, 50);
            cb_angular.Name = "cb_angular";
            cb_angular.Size = new Size(68, 19);
            cb_angular.TabIndex = 5;
            cb_angular.Text = "Angular";
            cb_angular.UseVisualStyleBackColor = true;
            // 
            // cb_python
            // 
            cb_python.AutoSize = true;
            cb_python.Location = new Point(11, 75);
            cb_python.Name = "cb_python";
            cb_python.Size = new Size(64, 19);
            cb_python.TabIndex = 6;
            cb_python.Text = "Python";
            cb_python.UseVisualStyleBackColor = true;
            // 
            // cb_node
            // 
            cb_node.AutoSize = true;
            cb_node.Location = new Point(11, 100);
            cb_node.Name = "cb_node";
            cb_node.Size = new Size(66, 19);
            cb_node.TabIndex = 7;
            cb_node.Text = "Node.js";
            cb_node.UseVisualStyleBackColor = true;
            // 
            // cb_javascript
            // 
            cb_javascript.AutoSize = true;
            cb_javascript.Location = new Point(11, 125);
            cb_javascript.Name = "cb_javascript";
            cb_javascript.Size = new Size(77, 19);
            cb_javascript.TabIndex = 8;
            cb_javascript.Text = "Javascript";
            cb_javascript.UseVisualStyleBackColor = true;
            // 
            // gb_genero
            // 
            gb_genero.Controls.Add(rb_masculino);
            gb_genero.Controls.Add(rb_femenino);
            gb_genero.Controls.Add(rb_no_binario);
            gb_genero.Location = new Point(348, 23);
            gb_genero.Name = "gb_genero";
            gb_genero.Size = new Size(200, 103);
            gb_genero.TabIndex = 0;
            gb_genero.TabStop = false;
            gb_genero.Text = "Genero";
            // 
            // rb_masculino
            // 
            rb_masculino.AutoSize = true;
            rb_masculino.Location = new Point(6, 22);
            rb_masculino.Name = "rb_masculino";
            rb_masculino.Size = new Size(80, 19);
            rb_masculino.TabIndex = 1;
            rb_masculino.TabStop = true;
            rb_masculino.Text = "Masculino";
            rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            rb_femenino.AutoSize = true;
            rb_femenino.Location = new Point(6, 50);
            rb_femenino.Name = "rb_femenino";
            rb_femenino.Size = new Size(78, 19);
            rb_femenino.TabIndex = 2;
            rb_femenino.TabStop = true;
            rb_femenino.Text = "Femenino";
            rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_no_binario
            // 
            rb_no_binario.AutoSize = true;
            rb_no_binario.Location = new Point(6, 75);
            rb_no_binario.Name = "rb_no_binario";
            rb_no_binario.Size = new Size(81, 19);
            rb_no_binario.TabIndex = 3;
            rb_no_binario.TabStop = true;
            rb_no_binario.Text = "No binario";
            rb_no_binario.UseVisualStyleBackColor = true;
            // 
            // lb_paises
            // 
            lb_paises.FormattingEnabled = true;
            lb_paises.ItemHeight = 15;
            lb_paises.Location = new Point(12, 253);
            lb_paises.Name = "lb_paises";
            lb_paises.Size = new Size(272, 124);
            lb_paises.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(348, 378);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar2
            // 
            btn_agregar2.Location = new Point(463, 378);
            btn_agregar2.Name = "btn_agregar2";
            btn_agregar2.Size = new Size(75, 23);
            btn_agregar2.TabIndex = 3;
            btn_agregar2.Text = "Agregar";
            btn_agregar2.UseVisualStyleBackColor = true;
            btn_agregar2.Click += btn_agregar2_Click;
            // 
            // label_pais
            // 
            label_pais.AutoSize = true;
            label_pais.Location = new Point(12, 235);
            label_pais.Name = "label_pais";
            label_pais.Size = new Size(28, 15);
            label_pais.TabIndex = 4;
            label_pais.Text = "Pais";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 441);
            Controls.Add(label_pais);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar2);
            Controls.Add(lb_paises);
            Controls.Add(gb_cursos);
            Controls.Add(gb_genero);
            Controls.Add(gb_datos);
            Name = "FormAlta";
            Text = "Form Agregar Ingresante";
            Load += FormAlta_Load;
            gb_datos.ResumeLayout(false);
            gb_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_value).EndInit();
            gb_cursos.ResumeLayout(false);
            gb_cursos.PerformLayout();
            gb_genero.ResumeLayout(false);
            gb_genero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_datos;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numeric_value;
        private GroupBox gb_cursos;
        private CheckBox cb_csharp;
        private CheckBox cb_angular;
        private CheckBox cb_python;
        private CheckBox cb_node;
        private CheckBox cb_javascript;
        private GroupBox gb_genero;
        private RadioButton rb_masculino;
        private RadioButton rb_femenino;
        private RadioButton rb_no_binario;
        private ListBox lb_paises;
        private Button btn_cancelar;
        private Button btn_agregar2;
        private Label label_pais;
    }
}