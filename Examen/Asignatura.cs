using System.Security.Cryptography.X509Certificates;

public class Asignatura : Alumno, IAsignatura;
{
  public int N1 { get; set; }
  public int N2 { get; set; }
  public int N3 { get; set; }
  public string NomAsignatura { get; set; }
  public string Horario { get; set; }
  public string NomDecente { get; set; }

  public Asignatura (string Name, string Numcuenta, string Email, int N1, int N2, int N3, string NombreAsignatura, string Horario.
  string NombreDecente)

}