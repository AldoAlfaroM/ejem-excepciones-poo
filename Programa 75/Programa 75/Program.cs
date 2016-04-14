using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace empacadora
{
    class Program
    {
        //Programa 75 excepcion personalizada
        class ExcepcionEmpacadora : Exception
        {
            public ExcepcionEmpacadora()
            {
                Console.WriteLine("Son demasiados paquetes, favor de detener produccion por hoy");
            }
        }
    
        static void Main(string[] args)
        {
            //variables auxiliares
            int opcion = 0;
            int paquetes=0;

            do
            {
                try
                {
                    //menu 
                    Console.Clear();
                    Console.WriteLine("\t--Menu--");
                    Console.WriteLine("\n<1> para empaquetar mercancia");
                    Console.WriteLine("\n<2> para salir");
                    opcion = Convert.ToInt16(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese cantidad de paquetes en existencia: ");
                            paquetes = Convert.ToInt32(Console.ReadLine());
                            if (paquetes > 10000)
                            {
                                throw new ExcepcionEmpacadora();
                            }
                            if (paquetes < 0)
                            {
                                throw new InvalidOperationException();
                            }
                            else
                            {
                                Console.Write("{0} paquete(s) de mercancia se ha(n) envuelto exitosamente", paquetes);
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("saliendo...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ingrese opcion válida");
                            Console.ReadKey();
                            break;
                            
                    }

                    //capturar datos
                }
                catch(ExcepcionEmpacadora EE)
                {
                    Console.WriteLine("\nMensaje de error :" + EE.Message);
                    Console.WriteLine("\nRuta de error :" + EE.StackTrace);
                    Console.ReadKey();                   
                }
                catch (InvalidOperationException IE)
                {
                    Console.WriteLine("\nMensaje de error :" + IE.Message);
                    Console.WriteLine("\nRuta de error :" + IE.StackTrace);
                    Console.ReadKey();
                }
                catch (FormatException FE)
                {
                    Console.WriteLine("\nMensaje de error :" + FE.Message);
                    Console.WriteLine("\nRuta de error :" + FE.StackTrace);
                    Console.ReadKey();
                }


            } while (opcion != 2);
                        
        }
    }
}

