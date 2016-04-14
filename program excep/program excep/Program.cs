using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class armas : Exception
        {
            public armas()
            {
                Console.WriteLine("Error no cuenta con dinero sufuciente");
            }
        }
        static void Main(string[] args)
        {
            //variables auxiliares
            double cantidad;
            int opcion;
            do
            {
                Console.Clear();
                //captura de datos
                
                Console.Write("\nMenu de opciones\n\nSeleccione un arma:");
                Console.Write("\n1.- Metralladora");
                Console.Write("\n2.- Revolver");
                Console.Write("\n3.- Manopla");
                Console.Write("\n4.-Salir\n");

                opcion = Convert.ToInt16(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        // captura de datos
                        try
                        {
                            Console.Write("Ingrese la cantidad de dinero disponible :");
                            cantidad = Convert.ToDouble(Console.ReadLine());
                            if (cantidad < 500)
                            {
                                throw new armas();
                            }
                        }
                        catch (armas A)
                        {
                            Console.WriteLine("\nMensaje de error : " + A.Message);
                            Console.WriteLine("\nRuta  de error : " + A.StackTrace);
                        }
                        finally
                        {
                            Console.Write("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }


                        break;
                    case 2:
                        try
                        {
                            Console.Write("Ingrese la cantidad de dinero disponible :");
                            cantidad = Convert.ToDouble(Console.ReadLine());
                            if (cantidad < 300)
                            {
                                throw new armas();
                            }
                        }
                        catch (armas A)
                        {
                            Console.WriteLine("\nMensaje de error : " + A.Message);
                            Console.WriteLine("\nRuta  de error : " + A.StackTrace);
                        }
                        finally
                        {
                            Console.Write("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.Write("Ingrese la cantidad de dinero disponible :");
                            cantidad = Convert.ToDouble(Console.ReadLine());
                            if (cantidad < 1000)
                            {
                                throw new armas();
                            }
                        }
                        catch (armas A)
                        {
                            Console.WriteLine("\nMensaje de error : " + A.Message);
                            Console.WriteLine("\nRuta  de error : " + A.StackTrace);
                        }
                        finally
                        {
                            Console.Write("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default :
                        Console.Write("\nIngrese una opcion valida");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 4);
        }
    }
}
