using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        //p72
        static void Main(string[] args)
        {
            //variables auxiliares
            int B, P; double R;
            try { //captura datos
                Console.Write("\nAlimenta el valor de la base: ");
                B = Int32.Parse(Console.ReadLine());
                Console.Write("\nAlimenta el valor de la potencia: ");
                P = Int32.Parse(Console.ReadLine());
                //operacion
                R = Math.Pow(B, P);
                //despliegue de resultado
                Console.WriteLine("\nEl resultado es: {0}", R);
                Console.WriteLine("\nPresione <enter> para continuar...");
                Console.ReadKey();                
        }
                //objeto f
            catch (FormatException f)
            {
                Console.WriteLine("\nMensaje del error: " +f.Message);
                Console.WriteLine("\nRuta del Error: " + f.StackTrace);
                Console.Write("\nPresione <enter> para continuar...");
                Console.ReadKey();
            } 
            finally
            {
                Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                Console.Write("\npresione <enter> para salir del programa");
                Console.ReadKey();
            }
    }//fin main
    }
}
