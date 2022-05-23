namespace DesafioTecnicoFramework.Api.Domain;

public class Decompose
{
    public List<int> Divisores { get; set; }
    public List<int> Primos { get; set; }

    public Decompose()
    {
        Divisores = new List<int>();
        Primos = new List<int>();
    }
}