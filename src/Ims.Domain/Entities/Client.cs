namespace Ims.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public string? Teste { get; set; }

    public Client(string? teste)
    {
        Teste = teste;
    }
}
