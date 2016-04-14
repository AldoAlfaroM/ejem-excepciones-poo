using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa70
{
    public sealed class UsoArgumentException
    {
        public static int DividirPorDos(int numero)
        {
            if ((numero % 2) == 1)
            {
                throw new ArgumentException("El numero debe ser par.");
            }
            return numero / 2;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("\n\tDivisión de 100 entre 2 = {0}", DividirPorDos(100));

            try
            {
                Console.WriteLine("13 divido por {0}", DividirPorDos(13));
            }

            catch (ArgumentException ae)
            {
                Console.WriteLine("\n\tMensaje de error: {0}", ae.Message);
            }
            finally
            {
                Console.WriteLine("El bloque finally siempre se ejecuta");
                Console.ReadKey();
            }


            Console.ReadKey();
        }
    }

}