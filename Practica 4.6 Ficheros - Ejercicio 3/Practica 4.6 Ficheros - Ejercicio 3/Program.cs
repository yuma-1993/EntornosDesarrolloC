using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._6_Ficheros___Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string nombre = "campions.txt";
            if (File.Exists(nombre))
            {
               fichero = File.OpenText(nombre);
               Console.WriteLine("Hímno Añadido!");
               fichero.Close();
            }
            else
            {
                Console.WriteLine("No existe!");

                using (StreamWriter fichero2 = File.CreateText(nombre))
                {
                    fichero2.WriteLine("De las glorias deportivas que campean por España.  ");
                    fichero2.Write("va el Madrid con su bandera limpia y blanca que no empaña.");
                    fichero2.WriteLine(" Club castizo y generoso, todo nervio y corazón, veteranos y noveles, veteranos y noveles, miran siempre tus laureles con respeto y emoción. ¡Hala Madrid!, ¡Hala Madrid!");
                    fichero2.Close();
                }
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
