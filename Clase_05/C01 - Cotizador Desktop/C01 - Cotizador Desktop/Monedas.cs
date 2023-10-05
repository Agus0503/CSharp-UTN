using System.Windows.Forms;
using Billetes;

namespace C01___Cotizador_Desktop
{
    public partial class Monedas : Form
    {
        private bool estadoBtnLockCotizacion = false;
        

        public Monedas()
        {
            InitializeComponent();
            EstadoTxtCotizacion(false);
            EstadoDefaultTxts();
        }

        private void EstadoDefaultTxts()
        {
            txtEuroADolar.Enabled = false;
            txtEuroAEuro.Enabled = false;
            txtEuroAPeso.Enabled = false;

            txtDolarADolar.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtDolarAPeso.Enabled = false;

            txtPesoADolar.Enabled = false;
            txtPesoAEuro.Enabled = false;
            txtPesoAPeso.Enabled = false;
        }

        private void EstadoTxtCotizacion(bool estado)
        {
            txtCotizacionDolar.Enabled = estado;
            txtCotizacionEuro.Enabled = estado;
            txtCotizacionPeso.Enabled = estado;
        }

        private void btnConvetirEuro_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Obtiene los valores de cotización
            double cotizacionEuro = Convert.ToDouble(txtCotizacionEuro.Text);
            double cantidadEuro = Convert.ToDouble(txtEuro.Text);

            // Realiza la conversión
            //(Dolar, Euro, Peso) conversion = ConvertirMoneda(cantidadEuro, cotizacionEuro);

            (Dolar, Euro, Peso) conversion = ConvertirEuro(cantidadEuro, cotizacionEuro);

            // Muestra los resultados
            txtEuroAEuro.Text = conversion.Item2.GetCantidad().ToString();
            txtEuroADolar.Text = conversion.Item1.GetCantidad().ToString();
            txtEuroAPeso.Text = conversion.Item3.GetCantidad().ToString();
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Obtiene los valores de cotización
            double cotizacionDolar = Convert.ToDouble(txtCotizacionDolar.Text);
            double cantidadDolar = Convert.ToDouble(txtDolar.Text);

            // Realiza la conversión
            //(Dolar, Euro, Peso) conversion = ConvertirMoneda(cantidadDolar, cotizacionDolar);

            (Dolar, Euro, Peso) conversion = ConvertirDolar(cantidadDolar, cotizacionDolar);

            // Muestra los resultados
            txtDolarADolar.Text = conversion.Item1.GetCantidad().ToString();
            txtDolarAEuro.Text = conversion.Item2.GetCantidad().ToString();
            txtDolarAPeso.Text = conversion.Item3.GetCantidad().ToString();
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            double cotizacionPeso = Convert.ToDouble(txtCotizacionPeso.Text);
            double cantidadPeso = Convert.ToDouble(txtPeso.Text);

            // Realiza la conversión
            //(Dolar, Euro, Peso) conversion = ConvertirMoneda(cantidadPeso, cotizacionPeso);

            (Dolar, Euro, Peso) conversion = ConvertirPeso(cantidadPeso, cotizacionPeso);

            // Muestra los resultados
            //txtPesoADolar.Text = conversion.Item1.GetCantidad().ToString();
            txtPesoADolar.Text = conversion.Item1.GetCantidad().ToString();
            txtPesoAEuro.Text = conversion.Item2.GetCantidad().ToString();
            txtPesoAPeso.Text= conversion.Item3.GetCantidad().ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {

            if (estadoBtnLockCotizacion)
            {
                btnLockCotizacion.ImageIndex = 0;
                EstadoTxtCotizacion(false);
            }
            else
            {
                btnLockCotizacion.ImageIndex++;
                EstadoTxtCotizacion(true);
            }

            estadoBtnLockCotizacion = !estadoBtnLockCotizacion;

        }

        private bool ValidarCampos()
        {
            string[] campos = { txtCotizacionEuro.Text, txtEuro.Text, txtCotizacionDolar.Text, txtDolar.Text, txtCotizacionPeso.Text, txtPeso.Text };

            foreach (string campo in campos)
            {
                if (string.IsNullOrEmpty(campo))
                {
                    MessageBox.Show("Los campos de cotizacion/cantidad no pueden estar vacíos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }        

        private static (Dolar, Euro, Peso) CrearInstanciasMonedas(double cantidad, double cotizacion)
        {
            Dolar miDolar = new(cantidad);
            Euro miEuro = new(cantidad, cotizacion);
            Peso miPeso = new(cantidad, cotizacion);

            return (miDolar, miEuro, miPeso);
        }


        private static (Dolar, Euro, Peso) ConvertirMoneda(double cantidad, double cotizacion)
        {
            var instanciasMonedas = CrearInstanciasMonedas(cantidad, cotizacion);            

            // Convierte Dólares a Euros
            instanciasMonedas.Item2 = (Euro)instanciasMonedas.Item1;

            // Convierte Dólares a Pesos
            instanciasMonedas.Item3 = (Peso)instanciasMonedas.Item1;

            // Convierte Pesos a Dólares
            instanciasMonedas.Item1 = (Dolar)instanciasMonedas.Item3;

            // Convierte Pesos a Euros
            instanciasMonedas.Item2 = (Euro)instanciasMonedas.Item3;

            // Convierte Euros a Pesos
            instanciasMonedas.Item3 = (Peso)instanciasMonedas.Item2;

            // Convierte Euros a Dólares
            instanciasMonedas.Item1 = (Dolar)instanciasMonedas.Item2;

            return instanciasMonedas;
        }    

        private static (Dolar, Euro, Peso) ConvertirEuro(double cantidad, double cotizacion)
        {
            var instanciasMonedas = CrearInstanciasMonedas(cantidad, cotizacion);

            // Convierte Euros a Pesos
            instanciasMonedas.Item3 = (Peso)instanciasMonedas.Item2;

            // Convierte Euros a Dólares
            instanciasMonedas.Item1 = (Dolar)instanciasMonedas.Item2;
            
            return instanciasMonedas;

        }

        private static (Dolar, Euro, Peso) ConvertirDolar(double cantidad, double cotizacion)
        {
            var instanciasMonedas = CrearInstanciasMonedas(cantidad, cotizacion);

            // Convierte Dólares a Euros
            instanciasMonedas.Item2 = (Euro)instanciasMonedas.Item1;

            // Convierte Dólares a Pesos
            instanciasMonedas.Item3 = (Peso)instanciasMonedas.Item1;

            return instanciasMonedas;

        }

        private static (Dolar, Euro, Peso) ConvertirPeso(double cantidad, double cotizacion)
        {
            var instanciasMonedas = CrearInstanciasMonedas(cantidad, cotizacion);

            // Convierte Pesos a Dólares
            instanciasMonedas.Item1 = (Dolar)instanciasMonedas.Item3;

            // Convierte Pesos a Euros
            instanciasMonedas.Item2 = (Euro)instanciasMonedas.Item3;

            return instanciasMonedas;

        }
    }
}