using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica2CastingNumeros
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btConvertir1_Click(object sender, EventArgs e)
        {
            //Conversión Entero
            int result1;
            if (int.TryParse(tb1.Text, out result1))
            {
                //El doble
                tb3.Text = (result1 * 2).ToString();

                //La mitad
                tb4.Text = (result1 / 2).ToString();
            }
            else
            {
                Console.WriteLine("La conversión no fue exitosa");
            }
        }

        private void btConvertir2_Click(object sender, EventArgs e)
        {
            //Conversión Real
            float result2;
            if (float.TryParse(tb2.Text, out result2))
            {
                //El doble
                tb3.Text = (result2 * 2).ToString();

                //La mitad
                tb4.Text = (result2 / 2).ToString();
            }
            else
            {
                Console.WriteLine("La conversión no fue exitosa");
            }
        }
    }
}
