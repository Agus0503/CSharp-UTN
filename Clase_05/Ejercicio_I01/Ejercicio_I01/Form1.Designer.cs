namespace Ejercicio_I01
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
            textBoxName = new TextBox();
            textBoxApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSaludar = new Button();
            cmbMateria = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(27, 62);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(139, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(214, 62);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(139, 23);
            textBoxApellido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 25);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            label2.Click += Label2_Click;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(27, 224);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(99, 29);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += BtnSaludar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(27, 168);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(389, 23);
            cmbMateria.TabIndex = 5;
            cmbMateria.SelectedIndexChanged += Materia_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 127);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 6;
            label3.Text = "Materia Favorita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cmbMateria);
            Controls.Add(btnSaludar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxApellido;
        private Label label1;
        private Label label2;
        private Button btnSaludar;
        private ComboBox cmbMateria;
        private Label label3;
    }
}