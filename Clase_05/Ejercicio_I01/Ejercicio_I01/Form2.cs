using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    public partial class Form2 : Form
    {
        string? nombre;
        string? apellido;
        string? materiaFavorita;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nombre, string apellido, string materiaFavorita) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materiaFavorita = materiaFavorita;
        }


        private void Mensaje_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Mensaje.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materiaFavorita}";
        }
    }
}
