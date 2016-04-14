using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideporCero
{
    public sealed class DivideporCero
    {        
        static void Main(string[] args)
        {
            int dividendo = 13;
            int divisor = 0;

            try
            {
                Console.WriteLine("{0}/{1}", (dividendo / divisor));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error 1: intento de division entre cero!! ");
            }
            Console.WriteLine("presione cualquier tecla para salir del programa");
            Console.ReadKey();
        }
    }
}
