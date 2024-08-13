using System.Security.Cryptography.X509Certificates;

public class Asignatura : Alumno, IAsignatura
{
    public int N1 { get; set; }
    public int N2 { get; set; }
    public int N3 { get; set; }
    public string NomAsignatura { get; set; }
    public string Horario { get; set; }
    public string NomDecente { get; set; }

    public Asignatura(string Nombre, string NumeroCuenta, string Email, int n1, int n2, int n3, string NombreAsignatura, string horario,
    string NombreDecente)

    {
        Name = Nombre;
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

    public void Imprimier()
    { 
    
    }
}
