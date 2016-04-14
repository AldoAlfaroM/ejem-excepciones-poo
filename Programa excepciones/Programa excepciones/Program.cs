using System;
using System.Collections.Generic;

class Program
{
    class datosedad:Exception
    {
        public datosedad()
        {
            Console.WriteLine("\n\tla edad es muy alta");
        } 
   
    static void Main()
    {
        //variables
        int edad = 0;
        string nombre;

        //captura
        Console.Write("\n\tNombre: ");
        nombre = Console.ReadLine();
        Console.Write("\n\tEdad: ");
        edad = Int16.Parse(Console.ReadLine());

        try
        {
            if (edad >= 120)
            {
                throw new datosedad();
                Console.WriteLine("\nnombre  \nedad: {0}, {1}", nombre, edad);
            }
        }
        catch (datosedad d)
        { Console.Write(d.Message); }
        finally{Console.WriteLine("\n\tEl metodo finally siempre se ejecuta");}

        //detener
        Console.WriteLine("\n\tpresione cualquier tecla para salir");
        Console.ReadKey();
    }
}
}
