using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._8___Repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardamos los numeros en una lista
            String[] lista = txtNums.Text.Split(',');

            //Pasamos la lista a enteros
            int[] numeros = lista.Select(int.Parse).ToArray();

            //Revertimos el orden y lo mostramos en el label
            Array.Reverse(numeros);
            //Damos formato String al array para que se muestre cada elemento entre comas
            string numerosRevertidos = string.Join(",", numeros);
            label2.Text = numerosRevertidos;
        }
    }
}
