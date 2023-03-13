using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._6_Ficheros___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guardar la linea introducida en un archivo
            StreamWriter fichero = new StreamWriter("tecleado.txt");
            String texto = "";
            do
            {
                Console.WriteLine("Introduzca un texto");
                texto = Console.ReadLine();
                if (texto != "off")
                {
                    fichero.WriteLine(texto);
                }                
            } while (texto != "off");
            fichero.Close();
        }
    }
}
