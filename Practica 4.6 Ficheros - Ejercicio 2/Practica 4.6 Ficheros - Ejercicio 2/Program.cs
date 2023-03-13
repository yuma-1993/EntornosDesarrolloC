using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._6_Ficheros___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string linea;
            int lineaNum = 0;
            fichero = File.OpenText("tecleado.txt");

            while (lineaNum < 3 && (linea = fichero.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                lineaNum++;
            } 
            fichero.Close();

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
