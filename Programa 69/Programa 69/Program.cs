using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Invitado
    {
        private string Nombre;
        private string Apellido;
        private int Edad;

        public Invitado(string nombre, string apellido, int edad)
        {
            Nombre = nombre; Apellido = apellido;
            if (edad <= 30)
                throw new ArgumentOutOfRangeException("\n\tedad", "\n\tdebe ser mayor a 30");
            else { Edad = edad; }
        }
        public override string  ToString()
        {
            return string.Format("\n\tNombre: {0} \n\tApellido: {1} \n\tEdad: {2}", Nombre, Apellido, Edad);
        }
    }

    public sealed class UsoArgumentOutOfRangeException
    {
        public static void Main(string[] args)
        {
            //variables aux
            int opcion;
            do
            {
                //menu 
                Console.Clear();
                Console.Write("--menu--");
                Console.Write("\ningresa la opcion deseada");
                Console.Write("\n\n<1> para capturar tus datos");
                Console.Write("\n<2> para salir del programa\n\n");
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        try
                        {
                            //capurar datos
                            Console.Clear();
                            Console.Write("\n\tIngrese el nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("\tIngrese el apellido: ");
                            string apellido = Console.ReadLine();
                            Console.Write("\tIngrese la edad: ");
                            int edad = Int16.Parse(Console.ReadLine());

                            Invitado i = new Invitado(nombre, apellido, edad);
                            Console.WriteLine(i.ToString());
                        }
                        catch (ArgumentOutOfRangeException a)
                        {
                            Console.WriteLine("\nMensaje de error: {0}", a.Message); //obj.propiedad
                        }
                        finally
                        {
                            Console.WriteLine("\n\tEl bloque finally siempre se ejecuta");
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

            Console.ReadKey();
        }//fin main

    }//fin sealed class

}//fin namespace


