using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._7___Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double result = 0;
            const double precioKilometro = 0.39;

            //Almacenamos el valor de cada numeriUpDown
            int valor1 = (int)numericUpDown1.Value;
            int valor2 = (int)numericUpDown2.Value;

            //Comprobamos si el valor1 es mayor o menor o igual que el valor2
            if (valor1 > valor2)
            {
                MessageBox.Show("El valor de los Km de inicio no puede ser mayor que los km de finalización");
            }else
            {
                //Realizar el calculo
                result = (valor2 - valor1) * precioKilometro;
                resultado.Text = result.ToString();

                //Volver visible el botón "ver kilometros"
                btnKilometros.Visible = true;
            }
        }

        private void btnKilometros_Click(object sender, EventArgs e)
        {
            int valor1 = (int)numericUpDown1.Value;
            int valor2 = (int)numericUpDown2.Value;
            int kilometros = valor2 - valor1;
            MessageBox.Show(kilometros + " kilometros.");
        }
    }
}
