using Grados;

namespace Ejercicio_C02
{
    public partial class Form1 : Form
    {
        private double gFahrenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txbFahrenheitAFahrenheit.Enabled = false;
            txbFahrenheitACelcius.Enabled = false;
            txbFahrenheitAKelvin.Enabled = false;

            txbCelciusAFahrenheit.Enabled = false;
            txbCelciusACelcius.Enabled = false;
            txbCelciusAKelvin.Enabled = false;

            txbKelvinAFahrenheit.Enabled = false;
            txbKelvinACelcius.Enabled = false;
            txbKelvinAKelvin.Enabled = false;
        }

        private void BtnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbFahrenheit.Text))
            {                               
                if (VerificarCadena(txbFahrenheit.Text))
                {
                    Fahrenheit fahrenheit = new();
                    gFahrenheit = double.Parse(txbFahrenheit.Text);
                    double convCelcius = fahrenheit.ConvertirACelcius(gFahrenheit);
                    txbFahrenheitACelcius.Text = convCelcius.ToString();

                    double convKelvin = fahrenheit.ConvertirAKelvin(gFahrenheit);
                    txbFahrenheitAKelvin.Text = convKelvin.ToString();

                    txbFahrenheitAFahrenheit.Text = gFahrenheit.ToString();
                }
                else
                {
                    MessageBox.Show("El dato ingresado no es numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo de grados esta vacio!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void BtnConvertirCelsius_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbCelcius.Text))
            {                
                if (VerificarCadena(txbCelcius.Text))
                {
                    Celcius celcius = new();
                    double gCelcius = double.Parse(txbCelcius.Text);

                    double convFahrenheit = celcius.ConvertirAFahrenheit(gCelcius);
                    txbCelciusAFahrenheit.Text = convFahrenheit.ToString();

                    double convKelvin = celcius.ConvertirAKelvin(gCelcius);
                    txbCelciusAKelvin.Text = convKelvin.ToString();

                    txbCelciusACelcius.Text = gCelcius.ToString();
                }
                else
                {
                    MessageBox.Show("El dato ingresado no es numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("El campo de grados esta vacio!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BtnConvertirKelvin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbKelvin.Text))
            {
                if (VerificarCadena(txbKelvin.Text))
                {
                    Kelvin kelvin = new();

                    double gKelvin = double.Parse(txbKelvin.Text);

                    double convCelcius = kelvin.ConvertirACelcius(gKelvin);
                    txbKelvinACelcius.Text= convCelcius.ToString();

                    double convFahrenheit = kelvin.ConvertirAFahrenheit(gKelvin);
                    txbKelvinAFahrenheit.Text= convFahrenheit.ToString();

                    txbKelvinAKelvin.Text = gKelvin.ToString();
                }
                else
                {
                    MessageBox.Show("El dato ingresado no es numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("El campo de grados esta vacio!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        
        private bool VerificarCadena(string cadena)
        {
            if (double.TryParse(cadena, out gFahrenheit))
            {
                return true;
            }

            return false;
        }
    }
}