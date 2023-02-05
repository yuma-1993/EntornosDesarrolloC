using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4._4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos estudiantes quiere calificar?");
            int estudiantes = int.Parse(Console.ReadLine());
            float sumaTotal = 0;

            for (int i = 1; i <= estudiantes; i++)
            {
                Console.WriteLine("Nombre: ");
                Console.ReadLine();
                Console.WriteLine("NOTA 1: ");
                float nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NOTA 2: ");
                float nota2 = int.Parse(Console.ReadLine());
                float promedio = (nota1 + nota2) / 2;
                Console.WriteLine("PROMEDIO: " + promedio);
                sumaTotal = sumaTotal + promedio;
            }
            Console.WriteLine("SUMA TOTAL ES: " + sumaTotal);
            Console.WriteLine("MEDIA ARITMETICA ES: " + sumaTotal/estudiantes);
            Console.ReadLine();
        }
    }
}
