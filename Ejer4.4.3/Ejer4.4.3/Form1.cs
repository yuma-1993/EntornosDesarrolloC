using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // programa que usa la función Math.PI
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("name is " + name + "\nx is " + x + "\nd is " + d);
            // Para qué sirve \n??
            //SOLUCIÓM: Provoca un salto de linea. En este caso dos.
            // Qué hace la función PI
            //SOLUCIÓN: Equivale al número PI que posteriormente es dividido por 2
            // cuál es el valor de la variable d?
            //SOLUCIÓN: El valor de la variable d es 1.5707963267948966

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < 10)
            {
                cont = cont + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                cont = cont - 1;
            }
            // cuanto vale cont?
            //SOLUCIÓN: 5
            MessageBox.Show("La respuesta es: " + cont);
        }
    }
}
