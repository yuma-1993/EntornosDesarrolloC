using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4._4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 15; /*esto es un comentario. Cuando acabes de escribir, depura y Fija un
            break-point aquí y ejecuta paso a paso*/
            num = num + 10;
            num = 12 - (42 / 7);
            num++;
            num *= 3;
            // Pregunta 1: Qué valor tiene num aquí??
            //SOLUCIÓN: 21
            int cont = 0;
            cont++;
            cont--;
            // fija otro break
            // Pregunta 2: Qué valor tiene cont aquí??
            //sOLUCIÓN: 0
            string result = "Hola";
            result += "otra vez" + result;
            MessageBox.Show(result);
            result = "the value is: " + cont;
            // Pregunta 3:Qué valor tiene result aquí?? result=” ”; 
            //SOLUCIÓN: the value is: 0
            //fija otro break
            // Pregunta 3: Qué valor tiene result aquí??
            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            // Pregunta 4: Qué valor tiene yesNo aquí??
            //SOLUCIÓN: False
        }
    }
}
