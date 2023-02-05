using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3TiposDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introducir 2 numero por consola
            Console.WriteLine("Primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            //Suma
            int sum = num1 + num2;
            Console.WriteLine("La suma es: " + sum);
            //Resta
            int rest = num1 - num2;
            Console.WriteLine("La suma es: " + num1 + " - " + num2 + " = " + rest);
            //Multiplicacion
            int mult = num1 * num2;
            Console.WriteLine("La multiplicación es: " + mult);
            //Division
            int div = num1 / num2;
            Console.WriteLine("La división es: " + div);
            //Residuo
            int residuo = num1 % num2;
            Console.WriteLine("El residuo es: " + residuo);

            //Pulsa una tecla para salir
            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadLine();
        }
    }
}
