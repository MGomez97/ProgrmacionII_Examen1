using System;
using System.Globalization;
using System.Reflection.Metadata;

class Progam
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese el Nombre del Alumno");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Numero de cuenta del alumno");
            string numcuenta = Console.ReadLine();

            Console.WriteLine("Ingrese Correo del Alumno");
            string email = Console.ReadLine();

            Console.WriteLine("Ingrese nota del primer parcial: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0 || n1 > 30)
                throw new Exception("");

        }
    }

}