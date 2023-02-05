using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3FuncionesMATH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for (int fila = 1; fila <= n; fila++)
            {
                for (int col = 1; col <= n - fila; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= 2 * fila - 1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("adios");
            Console.Read();
        }
    }
}
