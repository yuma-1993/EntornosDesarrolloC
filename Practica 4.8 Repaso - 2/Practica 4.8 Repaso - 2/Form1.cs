using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._8_Repaso___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cadena = txt_palindromo.Text;
            //MEDIANTE MÉTODOS DE LA CLASE ARRAY
            //Tenemos que convertir explícitamente el string en un array
            //para poder usar los métodos de esta clase
            char[] arrayOriginal = cadena.ToCharArray();
            //El método. Reverse permite invertir un array
            Array.Reverse(arrayOriginal);

            string cadenaReverse = new string(arrayOriginal);

            if (cadena == cadenaReverse)
            {
                label2.Text = "Es un palíndromo";
            }else
            {
                label2.Text = "No es un palíndromo";
            }

        }
    }
}
