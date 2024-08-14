using System.Security.Cryptography.X509Certificates;

public class Asignatura : Alumno, IAsignatura
{
    public int N1 { get; set; }
    public int N2 { get; set; }
    public int N3 { get; set; }
    public string NomAsignatura { get; set; }
    public string Horario { get; set; }
    public string NomDecente { get; set; }

    public Asignatura(string nombre, string NumeroCuenta, string Email, int n1, int n2, int n3, string NombreAsignatura, string horario,
    string NombreDecente)

    {
        Name = nombre;
        NumCuenta = NumeroCuenta;
        Correo = Email;
        N1 = n1;
        N2 = n2;
        N3 = n3;
        NomAsignatura = NombreAsignatura;
        Horario = horario;
        NomDecente = NombreDecente;

    }

    public double CalculaNotaFinal()
    {
        return (N1 + N2 + N3) / 3.0;
    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal < 60)
            return "Reprobado";
        else if (notaFinal < 80)
            return "Bueno";
        else if (notaFinal < 90)
            return "Muy Bueno";
        else
            return "Sobresaliente";
    }

    public void Imprimir()
    { 
    base.Imprimir();

        double notaFinal1 = CalculaNotaFinal();
        double notaFinal2 = CalculaNotaFinalParametros(N1,N2,N3);

        string Mensaje1 = MensajeNotaFinal(notaFinal1);
        string Mensaje2 = MensajeNotaFinal(notaFinal2);

        Console.WriteLine("Datos Sobre la Asignatura");
        Console.WriteLine($"Clase: {NomAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Docente: {NomDecente}");

        Console.WriteLine($"Nota Final 1: {notaFinal1} - {Mensaje1}");
        Console.WriteLine($"Nota Final 2: {notaFinal2} - {Mensaje2}");
    }

        private double CalculaNotaFinalParametros(int n1,int n2, int n3)
    {
        return (n1 + n2 + n3) / 3.0;
    }
}
