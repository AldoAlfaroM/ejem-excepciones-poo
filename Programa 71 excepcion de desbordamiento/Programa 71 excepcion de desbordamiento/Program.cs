using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        //P71 excepcion de desbordamiento
        static void Main(string[] args)
        {
            //variables auxiliares byte 256
            byte num1, num2, suma;
            try
            { //captura de datos
                Console.Write("\nAlimenta el 1er numero: ");
                num1 = Byte.Parse(Console.ReadLine());
                Console.Write("\nAlimenta el 2do numero: ");
                num2 = Byte.Parse(Console.ReadLine());

                //operacion
                suma = (byte)(num1 + num2);

                //despliegue de resultado
                Console.WriteLine("\nEl resultado de la suma es: {0}", suma);
                Console.Write("\npresione <enter> para continuar...");
                Console.ReadKey();

            }
            catch (OverflowException o)
            {//o.propiedad
                Console.WriteLine("\nMansaje de error: " + o.Message);
                Console.WriteLine("\nRuta del error: " + o.StackTrace);
                Console.WriteLine("\nPresione <enter para continuar>"); 
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
