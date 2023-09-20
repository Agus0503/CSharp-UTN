using Biblioteca;

namespace Ejercicio_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxPaises.Items.Add("Argentina");
            boxPaises.Items.Add("Chile");
            boxPaises.Items.Add("Uruguay");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {                
                List<string> cursos = new();
                
                foreach (Control item in gboxCursos.Controls)
                {
                    if (item is CheckBox checkBox && checkBox.Checked)
                    {
                        cursos.Add(item.Text);
                    }
                }

                string genero = "";
                foreach (Control item in gboxGenero.Controls)
                {
                    if (item is RadioButton radioButton && radioButton.Checked)
                    {
                        genero = radioButton.Text;
                        break;
                    }
                }

                Ingresante ingresante = new(cursos.ToArray(), tboxDireccion.Text, (int)nmEdad.Value, genero , tboxName.Text , boxPaises.Text);
                MessageBox.Show(ingresante.Mostrar());                

            }
            else
            {
                MessageBox.Show("Hay datos sin completar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {

            foreach (Control item in gboxUsuario.Controls)
            {
                if (item is TextBox || item is NumericUpDown)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        return false;
                    }
                }             
            }            

            if (!gboxGenero.Controls.OfType<RadioButton>().Any(radioButton => radioButton.Checked))
            {
                return false;
            }

            if (!gboxCursos.Controls.OfType<CheckBox>().Any(checkBox => checkBox.Checked))
            {
                return false;
            }

            if (boxPaises.SelectedItem == null) 
            {
                return false;
            }


            return true;
        }

    }
}