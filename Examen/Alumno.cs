using System;

public class Alumno
{
    public string Name { get; set; }
    public string NumCuenta { get; set; }
    public string Correo {  get; set; }

    public void Imprimir () {

        Console.WriteLine("Datos del Alumno");
        Console.WriteLine($"Nombre: {Name}");
        Console.WriteLine($"Numero De Cuenta: {NumCuenta}");
        Console.WriteLine($"Correo: {Correo}");

    }
}