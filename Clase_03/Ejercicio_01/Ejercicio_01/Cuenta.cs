using System;
using System.Text;

namespace Ejercicio_01
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }


        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {getTitular()} \nSaldo disponible: {getCantidad()}");

            return sb.ToString();
        }

        public void ingresar(double monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }        

        public double retirar(double monto) => cantidad -= monto;                                                    

        public string getTitular() => titular;
        public double  getCantidad() => cantidad;
    }
}
