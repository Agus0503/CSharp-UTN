using System.Collections;
using System.Text;

namespace Ejercicio_I01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Form2 form2 = new(textBoxName.Text, textBoxApellido.Text, cmbMateria.Text);
                form2.Show();
            }
        }

        private bool Validar()
        {
            bool esValido = true;
            string nombre = textBoxName.Text;
            string apellido = textBoxApellido.Text;

            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(nombre))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;

        }

        private void Materia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programaci�n I");
            cmbMateria.Items.Add("Laboratorio de Computaci�n I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Ingl�s I");
            cmbMateria.Items.Add("Matem�tica");
            cmbMateria.Items.Add("Programaci�n II");
            cmbMateria.Items.Add("Laboratorio de Computaci�n II");
            cmbMateria.Items.Add("Ingl�s II");
            cmbMateria.Items.Add("Metodolog�a de la investigaci�n");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estad�stica");
            cmbMateria.SelectedIndex = 0;
        }
    }
}