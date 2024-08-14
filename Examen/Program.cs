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

            Console.WriteLine("Ingrese el nombre de la Clase");
            string NombreAsignatura = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ingrese nota del primer parcial: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0 || n1 > 30)
                throw new Exception("La nota del primer o segundo parcial sobrepasa del 30%");

            Console.WriteLine("Ingrese nota del segundo parcial: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 < 0 || n2 > 30)
                throw new Exception("La nota del primer o segundo parcial sobrepasa del 30%");

            Console.WriteLine("Ingrese nota del tercer parcial: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n3 < 0 || n3 > 40)
                throw new Exception("La nota del primer o segundo parcial sobrepasa del 40%");

            Asignatura asignatura = new Asignatura(nombre, numcuenta, email, n1, n2, n3, NombreAsignatura, "Miercoles  1:00  -  3:00", "Ing. Juan");

            asignatura.Imrimir();

        }
        catch (FormatException ge)
        {
            Console.WriteLine($"Error de formato {ge.Message}");
        }
        catch (Exception e) 
        {
            Console.WriteLine($"error {e.Message}");
        }
         
    }

}