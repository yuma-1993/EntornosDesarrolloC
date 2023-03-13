using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4._8___Repaso___Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            //Crea un “generador de númerosaleatorios"
            int[] lista_aleatorios = new int[20];
            for (int i = 0; i < lista_aleatorios.Length; i++)
            {
                lista_aleatorios[i] = aleatorio.Next(0, 99);
                Console.WriteLine(lista_aleatorios[i]);
            }
            Console.WriteLine(lista_aleatorios.ToString());
            //Introducitr número por pantalla
            Console.WriteLine("Introduzca un número por pantalla");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            int numeroContador = 0;
            bool isDentro = false;
            //Comprueba si el numero está entre los que puedan salir
                //Comprobar si está entre los que se han generao o no
                for (int i = 0; i < lista_aleatorios.Length; i++)
                {
                    if (lista_aleatorios[i] == numero)
                    {
                        numeroContador++;
                        isDentro = true;
                    }
                }
                if (isDentro == true)
                {
                    Console.WriteLine("El número está dentro y se repite " + numeroContador + " veces.");
                }else
                {
                Console.WriteLine("El número no está dentro.");
                }
            Console.WriteLine("El programa ha finalizado. Pulsa una tecla para salir...");
            Console.ReadKey();

        }
    }
}
