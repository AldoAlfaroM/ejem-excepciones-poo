using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; //libreria adicional para manejar archivos (input output)

namespace ConsoleApplication1
{
    public class Processfile
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader Sr = File.OpenText("Archivo");

                Console.WriteLine("La primera linea del archivo es {0}", Sr.ReadLine());
                Sr.Close();
            } 
            catch(Exception e)
            {
                Console.WriteLine("error al abrir el archivo", e);
            }

            //detener
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
            }
        }
    }

