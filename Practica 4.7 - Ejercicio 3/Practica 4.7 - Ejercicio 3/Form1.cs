using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4._7___Ejercicio_3
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos el array de numeros
            string[] lista = txt_moda.Text.Split(',');
            int[] numeros = lista.Select(int.Parse).ToArray();

            //Creamos un diccionario para guardar las repeticiones
            Dictionary<int, int> repeticiones = new Dictionary<int, int>();
            foreach (int numero in numeros)
            {
                //Si el numero no se ha repetido aun, creamos el numero y asignamos un valor de cero
                if (!repeticiones.ContainsKey(numero))
                {
                    repeticiones[numero] = 0;
                }
                //En caso de que ya este el numero incrementamos en uno su valor
                repeticiones[numero]++;
            }

            //Mostramos el número que más se repite
            int moda = repeticiones.OrderByDescending(kv => kv.Value).First().Key;

            //Mostrar el MessageBox
            MessageBox.Show("La moda es " + moda);
        }
    }
}
