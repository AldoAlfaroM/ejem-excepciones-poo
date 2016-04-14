using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {

        /* usar (throw)
         * if:
         * capturar numero entero llamado Base
         * else: si el numero es negativo lanzar la excepcion ArgumentOutOfRangeException,
         * si no, si el numero es mayor a 500,000
         * lanzar la excepcion OverflowException,
         * en caso contrario sacar su raiz cuadrada
         * con la funcion matematica Math.Sqrt(Base)
         * y desplazar el resultado obtenido.
         * 3 catch
         * -Implementar ademas la excepcion de FormatException por si ocurrieran errores en la captura de datos
         * - en el bloque finally desplegar el mansaje de programas anteriores
         * *desplegar en el bloque catch mansaje, TrackTrace
         * incluir menu 1.-calcular la raiz cuadrada 2.-salir del programa ok
         */
        static void Main(string[] args)
        {
            //variables
            int Base = 0, menu;
            do
            {
                //datos menu
                Console.WriteLine("Menu");
                Console.WriteLine("calcular la raiz cuadrada <1>"
                                + "\nSalir del programa      <2>");
                Console.Write("Introduce opcion: ");
                menu = Int16.Parse(Console.ReadLine());

                //menu
                switch (menu)
                {
                    case 1:
                        try
                        {

                            //captura datos
                            Console.Write("\nCaptura Numero entero: ");
                            Base = Int32.Parse(Console.ReadLine());
                            if (Base < 0)
                            { throw new ArgumentOutOfRangeException(); }
                            else if (Base > 500000) { throw new OverflowException(); }
                            Console.WriteLine("\nLa raiz cuadrada del numero {0} es: {1}", Base, Math.Sqrt(Base));
                        }
                        catch (ArgumentOutOfRangeException AE)
                        {
                            Console.WriteLine("Error: " + AE.Message);
                            Console.WriteLine("Ruta del error: " + AE.StackTrace);
                            Console.ReadKey();
                        }
                        catch (FormatException FE)
                        {
                            Console.WriteLine("Error: " + FE.Message);
                            Console.WriteLine("Ruta del error: " + FE.StackTrace);
                            Console.ReadKey();
                        }
                        catch (OverflowException OE)
                        {
                            Console.WriteLine("Error: " + OE.Message);
                            Console.WriteLine("Ruta del error: " + OE.StackTrace);
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.Write("\npresione <enter> para salir del programa");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nbye bye, hasta la proxima...");
                        Console.ReadKey();                        
                        break;
                    default:
                        Console.WriteLine("\nEl valor no es valido x.x");
                        break;
                }
                //Detener pantalla
                Console.WriteLine("\n\nPresione cualquier tecla para continuar el programa");
                Console.ReadKey();
                Console.Clear();

            } while (menu != 2);
           
        }//fin main
    }
}

            
        
            
            
            
            
        
            
            
        
    

    

