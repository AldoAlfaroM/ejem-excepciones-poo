using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //p77 ejercicio excepciones
        /*
         * implementar una applicationExeption para calcular la ecuacion
         * cuadratica que despliegue el mensaje "la ecuacion cuadratica No tiene solucion"
         * en su constructor.
         * En el Main utilizar el siguiente menu:
         * 1.-calcular ecuacion cuadratica
         * 2.-salir del programa
         * En el caso 1:
         * capturar los valores de a,b y c
         * calcular el discriminante = b^2/4ac
         * si el discriminanate es < 0 entonces lanzar la excepcion de la ecuacion cuadratica,
         * sino
         * Calcular los valores de x1 y x2
         * x=-b +- raiz de: (b^2-4ac)/2a y desplegar los resultados obtenidos en pantalla
         * 
         * ademas implementar la exepcion de formato por si ocurren errores en la captura de datos
         * En el caso 2:
         * poner mensaje de salida del programa
         * *en los 2 catch desplegar mansaje y Ruta del error
         * En ek finally desplegar mansaje programas anteriores
         * 
         * Ejercicios 
         * 1.-x^2-5x+6=0 {3 \n2
         * 2.-x^2+6x+9=0 {3 \n3
         * 3.-x^2+4x-5=0 {10 \n-2
         * 4.-5x^2+x-1=0 {5 \n-10
         * 5.-x^2-x-3=0 {2 \n-1
         * 6.-x^2+x+5=0 ?
         * 7.-x^2+3x+3=0 ?
         * 8.-2x^2+x+4=0 ?
         * unidad VI flujos y archivos
         * 6.1 definiciones: archivo \nflujo: entrada y salida
         * 6.2 clasificacion de archivos: \ntexto \nbinario \n flujos que utilizan
         */
        class excepcionecuacion : Exception
        {
            public excepcionecuacion()
            {
                Console.WriteLine("\nLa ecuacion cuadratica no tiene solucion");
            }
        }

        static void Main(string[] args)
        {
            int opcion;
            double a, b, c, discriminante, x1, x2;

            do
            {
                //menu de opciones
                Console.Clear();
                Console.WriteLine("--Menu de opciones--");
                Console.WriteLine("1.-calcular ecuacion cuadratica");
                Console.WriteLine("2.-salir del programa");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        try
                        {
                            //captura
                            Console.Write("Capture el valor de a: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Capture el valor de b: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Capture el valor de c: ");
                            c = Convert.ToDouble(Console.ReadLine());

                            //cálculo del discriminante
                            //calcular el discriminante = b^2/4ac
                            discriminante = (Math.Pow(b, 2)) - 4 * a * c;
                            if (discriminante < 0)
                            {
                                throw new excepcionecuacion();
                            }
                            else
                            {
                                x1 = -b + Math.Sqrt(((Math.Pow(b, 2)) - 4 * a * c) / (2 * a));
                                x2 = -b - Math.Sqrt(((Math.Pow(b, 2)) - 4 * a * c) / (2 * a));
                                Console.WriteLine("el valor de x1 es {0}", x1);
                                Console.WriteLine("el valor de x2 es {0}", x2);
                            }
                        }
                        catch (FormatException FE)
                        {
                            Console.WriteLine("Error: " + FE.Message);
                            Console.WriteLine("Ruta del error: " + FE.StackTrace);
                            Console.ReadKey();
                        }
                        catch (excepcionecuacion EE)
                        {
                            Console.WriteLine("\nMensaje de error :" + EE.Message);
                            Console.WriteLine("\nRuta de error :" + EE.StackTrace);
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nIngrese una opcion valida");
                        break;
                }
            } while (opcion != 2);
            }
    }
}

