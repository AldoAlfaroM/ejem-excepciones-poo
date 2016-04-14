using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //programa 76
        class AngulosNegativosException : ApplicationException
        {
            //constructor
            public AngulosNegativosException() : base("No se puede calcular el seno de un angulo negativo") { }
        }
        static void Main(string[] args)
        {
            //variables auxiliares
            int angulo, opcion; double resultado;
            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu");
                Console.WriteLine("\n1.- Calcular seno de un angulo");
                Console.WriteLine("\n2.- Salir del programa");
                Console.Write("\nCual es tu opcion?: ");
                opcion = Int16.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        try
                        {
                            //captura de datos
                            Console.Write("\nAlimenta el valor del angulo: ");
                            angulo = Int32.Parse(Console.ReadLine());
                            if (angulo < 0) throw new AngulosNegativosException();
                            else
                            {
                                resultado = Math.Sin(angulo);
                                Console.WriteLine("\nEl seno del angulo es: " + resultado);
                                Console.Write("\npresione <enter> para regresar al menu...");
                                Console.ReadKey();
                            }
                        }
                        //creacion objeto
                        catch (AngulosNegativosException an)
                        {
                            Console.WriteLine("\nMensaje del error: " + an.Message);
                            Console.WriteLine("\nRuta del error: " + an.StackTrace);
                            Console.Write("\npresione <enter> para continuar");
                            Console.ReadKey();
                        }
                        catch (FormatException f)
                        {
                            //desplega mensaje y ruta del error
                            Console.WriteLine("\nMensaje del error: " + f.Message);
                            Console.WriteLine("\nRuta del error: " + f.StackTrace);
                            Console.ReadKey();
                        }
                        finally
                        {
                            //desplegar mensaje y ruta del error
                            Console.WriteLine("\nEl bloque finally siempre se ejecuta...");
                            Console.Write("\npresione <enter> para salir del programa");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.Write("\npresione <enter> para salir del programa");
                        Console.ReadKey();
                        break;
                    default: Console.Write("\nopcion inexistente presione <enter> para continuar");
                        Console.ReadKey();
                        break;
                }//fin switch
            } while (opcion != 2);
        }//fin main
    }
}
