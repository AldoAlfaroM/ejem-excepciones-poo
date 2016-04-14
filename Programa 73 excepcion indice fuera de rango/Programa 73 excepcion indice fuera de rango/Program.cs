using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        //p73 excepcion indice fuera de rango
        static void Main(string[] args)
        {
            //variables auxiliares
            int[] arreglo = new int[10];
            //creacion objeto
            Random R = new Random();
            try
            {//generacion aleatoria del arreglo
                for (int x = 0; x < arreglo.Length; x++)
                { arreglo[x] = R.Next(10, 99); }

                //ordenamiento del arreglo
                Array.Sort(arreglo);

                //despliegue del vector ordenado
                Console.WriteLine("\nArreglo Ordenado");
                for (int x = 0; x < arreglo.Length; x++)
                {
                    Console.Write("\npresione <enter> para continuar...");
                    Console.ReadKey();
                    //asignacion de valor indice invalido
                    arreglo[15] = 12345;
                }
            }
            catch (IndexOutOfRangeException i) //indice fura de rango
            {
                Console.WriteLine("\nMensaje del error: " + i.Message);
                Console.WriteLine("\nRuta del error: " + i.StackTrace);
                Console.Write("\npresione <enter> para continuar...");
                Console.ReadKey();
            }
            finally 
            {
                Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                Console.Write("\npresione <enter> para salir del programa");
                Console.ReadKey();
            }
       
        }
    }
}
