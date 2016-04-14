using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class compus : Exception
        {
            public compus()
            {
                Console.WriteLine("Error, usted no tiene dinero suficiente :c");
            }
        }
        static void Main(string[] args)
        {
            //variables
            int opcion;

            do
            {
                double dinero;
                //menu de opciones
                Console.Clear();
                Console.Write("Walmart SA de CV");
                Console.Write("\n\ndell <1>");
                Console.Write("\ntoshiba <2>");
                Console.Write("\nalienware <3>");
                Console.Write("\nSalir <4>\n\n");
                Console.Write("\nseleccione una opcion para comprar: ");
                opcion = Convert.ToInt16(Console.ReadLine());
                
                switch(opcion)
                {
                    case 1:
                        try
                        {
                            Console.Write("\nIngrese tu dinero disponible: ");
                            dinero = Convert.ToDouble(Console.ReadLine());
                            if (dinero < 3500)
                            {
                                throw new compus();
                            }
                            else
                            {
                                Console.WriteLine("usted ha comprado una computadora dell de {0}", dinero);
                            }
                        }
                            catch(compus c)
                        {
                            Console.WriteLine("\nMensaje de error :"+c.Message);
                            Console.WriteLine("\nRuta de error :"+c.StackTrace);
                        }
                        finally
                        {
                             Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }

                        break;
                        case 2:
                        try
                        {
                            Console.Write("\nIngrese tu dinero disponible");
                            dinero = Convert.ToDouble(Console.ReadLine());
                            if (dinero < 3000)
                            {
                                throw new compus();
                            }
                            else
                            {
                                Console.WriteLine("usted ha comprado una computadora toshiba de {0}", dinero);
                            }
                        }
                            catch(compus c)
                        {
                            Console.WriteLine("\nMensaje de error :"+c.Message);
                            Console.WriteLine("\nRuta de error :"+c.StackTrace);
                        }
                        finally
                        {
                             Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }

                        break;
                        case 3:
                        try
                        {
                            Console.Write("\nIngrese tu dinero disponible");
                            dinero = Convert.ToDouble(Console.ReadLine());
                            if (dinero < 20000)
                            {
                                throw new compus();
                            }
                            else
                            {
                                Console.WriteLine("usted ha comprado una computadora alienware de {0}", dinero);
                            }
                        }
                            catch(compus c)
                        {
                            Console.WriteLine("\nMensaje de error :"+c.Message);
                            Console.WriteLine("\nRuta de error :"+c.StackTrace);
                        }
                        finally
                        {
                             Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }

                        break;
                        case 4:
                        System.Environment.Exit(0);
                        break;
                    default :
                        Console.Write("\nIngrese una opcion valida");
                        break;
                }
            } while (opcion != 4);
            }
    }
}
