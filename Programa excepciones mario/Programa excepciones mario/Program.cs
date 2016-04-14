using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        class recicladora : Exception
        {
            public recicladora()
            {
                Console.Write("\nPeso en kilos no suficiente, favor de depositar mas basura");
            }
        }
        static void Main(string[] args)
        {
            double peso, res;
            int opcion;

            do{
                // menu de opciones
                Console.Clear();
                Console.Write("-------Seleccione una opcion------ ");
                Console.Write("\n1.- Vidrio ");
                Console.Write("\n2.- Carton");
                Console.Write("\n3.- Plastico");
                Console.Write("\n4.- Salir\n");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        // captura de datos
                        try
                        {
                        Console.Write("\nIngrese el peso en kilos: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        if (peso < 10)
                        {
                            throw new recicladora();
                        }
                        else
                        {
                            res = peso * 5;
                            Console.WriteLine("\nUsted ha generado : {0:C}",res);
                        }
                        }
                        catch(recicladora R)
                        {
                            Console.WriteLine("\nMensaje de error :"+R.Message);
                            Console.WriteLine("\nRuta de error :"+R.StackTrace);
                        }
                        finally
                        {
                             Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }

                        break;
                    case 2:
                        // captura de datos
                        try
                        {
                        Console.Write("\nIngrese el peso en kilos: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                            if(peso < 20)
                            {
                                throw new recicladora();
                            }
                            else
                            {
                                res = peso * 1.5;
                                Console.WriteLine("\nUsted ha generado : {0:C}", res);
                            }
                        }
                        catch(recicladora R)
                        {
                            Console.WriteLine("\nMensaje de error :"+R.Message);
                            Console.WriteLine("\nRuta de error :"+R.StackTrace);
                        }
                        finally
                        {
                             Console.WriteLine("\nEl bloque finally siempre se ejecuta");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        // captura de datos
                        try
                        {
                            Console.Write("\nIngrese el peso en kilos: ");
                            peso = Convert.ToDouble(Console.ReadLine());
                            if (peso < 30)
                            {
                                throw new recicladora();
                            }
                            else
                            {
                                res = peso * 2;
                                Console.WriteLine("\nUsted ha generado : {0:C}", res);
                            }
                        }
                        catch (recicladora R)
                        {
                            Console.WriteLine("\nMensaje de error :" + R.Message);
                            Console.WriteLine("\nRuta de error :" + R.StackTrace);
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


            }while(opcion !=4);
        }
    }
}
