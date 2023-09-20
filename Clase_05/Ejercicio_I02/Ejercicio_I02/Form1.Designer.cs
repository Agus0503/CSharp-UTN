namespace Ejercicio_I02
{
    partial class Form1
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
            gboxUsuario = new GroupBox();
            tboxDireccion = new TextBox();
            tboxName = new TextBox();
            label3 = new Label();
            nmEdad = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            gboxGenero = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gboxCursos = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            boxPaises = new ListBox();
            label4 = new Label();
            button1 = new Button();
            gboxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmEdad).BeginInit();
            gboxGenero.SuspendLayout();
            gboxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gboxUsuario
            // 
            gboxUsuario.Controls.Add(tboxDireccion);
            gboxUsuario.Controls.Add(tboxName);
            gboxUsuario.Controls.Add(label3);
            gboxUsuario.Controls.Add(nmEdad);
            gboxUsuario.Controls.Add(label2);
            gboxUsuario.Controls.Add(label1);
            gboxUsuario.Location = new Point(12, 12);
            gboxUsuario.Name = "gboxUsuario";
            gboxUsuario.Size = new Size(208, 185);
            gboxUsuario.TabIndex = 0;
            gboxUsuario.TabStop = false;
            gboxUsuario.Text = "Detalles de Usuario";
            // 
            // tboxDireccion
            // 
            tboxDireccion.Location = new Point(74, 80);
            tboxDireccion.Name = "tboxDireccion";
            tboxDireccion.Size = new Size(120, 23);
            tboxDireccion.TabIndex = 5;
            // 
            // tboxName
            // 
            tboxName.Location = new Point(74, 28);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(120, 23);
            tboxName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 140);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Edad";
            // 
            // nmEdad
            // 
            nmEdad.Location = new Point(74, 138);
            nmEdad.Name = "nmEdad";
            nmEdad.Size = new Size(120, 23);
            nmEdad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // gboxGenero
            // 
            gboxGenero.Controls.Add(radioButton3);
            gboxGenero.Controls.Add(radioButton2);
            gboxGenero.Controls.Add(radioButton1);
            gboxGenero.Location = new Point(274, 12);
            gboxGenero.Name = "gboxGenero";
            gboxGenero.Size = new Size(162, 140);
            gboxGenero.TabIndex = 2;
            gboxGenero.TabStop = false;
            gboxGenero.Text = "Genero";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(13, 99);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(41, 19);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "NB";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(13, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gboxCursos
            // 
            gboxCursos.Controls.Add(checkBox3);
            gboxCursos.Controls.Add(checkBox2);
            gboxCursos.Controls.Add(checkBox1);
            gboxCursos.Location = new Point(274, 158);
            gboxCursos.Name = "gboxCursos";
            gboxCursos.Size = new Size(162, 136);
            gboxCursos.TabIndex = 3;
            gboxCursos.TabStop = false;
            gboxCursos.Text = "Cursos";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(8, 106);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(78, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "JavaScript";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 69);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(50, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "C++";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(8, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(41, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // boxPaises
            // 
            boxPaises.FormattingEnabled = true;
            boxPaises.ItemHeight = 15;
            boxPaises.Location = new Point(12, 242);
            boxPaises.Name = "boxPaises";
            boxPaises.Size = new Size(208, 94);
            boxPaises.Sorted = true;
            boxPaises.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "Pais";
            // 
            // button1
            // 
            button1.Location = new Point(274, 313);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 386);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(boxPaises);
            Controls.Add(gboxCursos);
            Controls.Add(gboxGenero);
            Controls.Add(gboxUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gboxUsuario.ResumeLayout(false);
            gboxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmEdad).EndInit();
            gboxGenero.ResumeLayout(false);
            gboxGenero.PerformLayout();
            gboxCursos.ResumeLayout(false);
            gboxCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gboxUsuario;
        private GroupBox gboxGenero;
        private GroupBox gboxCursos;
        private Label label2;
        private Label label1;
        private Label label3;
        private NumericUpDown nmEdad;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox boxPaises;
        private Label label4;
        private TextBox tboxDireccion;
        private TextBox tboxName;
        private Button button1;
    }
}