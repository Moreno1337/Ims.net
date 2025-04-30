using Ims.Domain.ValueObjects;

namespace Ims.Domain.Entities;

public enum ClientType { NaturalPerson, LegalEntity }

public class Client
{
    public required int Id { get; init; }
    public required bool Status { get; init; }
    public ClientType Type { get; init; }
    public string? CPF { get; init; }
    public string? Name { get; init; }
    public DateTime? DateOfBirth { get; init; }
    public string? CNPJ { get; init; }
    public string? CompanyName { get; init; }
    public string? FantasyName { get; init; }
    public string? StateRegistration { get; init; }
    public int? BillingTerm { get; init; }
    public decimal? Fees { get; init; }
    public decimal? Fine { get; init; }
    public string? Telephone { get; init; }
    public string? Cellphone { get; init; }
    public required Address Address { get; init; }
    public string? Observations { get; init; }
    public List<string>? EmailList { get; init; } = new();

    private Client() { }

    public Client(
        int id,
        bool status,
        ClientType type,
        string? cpf,
        string? name,
        DateTime? dateOfBirth,
        string? cnpj,
        string? companyName,
        string? fantasyName,
        string? stateRegistration,
        int? billingTerm,
        decimal? fees,
        decimal? fine,
        string? telephone,
        string? cellphone,
        Address address,
        string? observations,
        List<string>? emailList
    )
    {
        if (type == ClientType.NaturalPerson)
        {
            ValidateNaturalPerson(cpf, name, dateOfBirth);
        }
        else
        {
            ValidateLegalEntity(cnpj, companyName);
        }

        this.Id = id;
        this.Type = type;
        this.CPF = cpf;
        this.Name = name;
        this.Status = status;
        this.DateOfBirth = dateOfBirth;
        this.StateRegistration = stateRegistration;
        this.CNPJ = cnpj;
        this.CompanyName = companyName;
        this.FantasyName = fantasyName;
        this.BillingTerm = billingTerm;
        this.Telephone = telephone;
        this.Cellphone = cellphone;
        this.Address = address;
        this.Observations = observations;
        this.EmailList = emailList;
        this.Fees = fees;
        this.Fine = fine;
    }

    private void ValidateNaturalPerson(string? cpf, string? name, DateTime? dateOfBirth) 
    {
        if (string.IsNullOrEmpty(cpf))
        {
            throw new ArgumentException("CPF is required.");
        }

        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name is required.");
        }

        if (dateOfBirth == null)
        {
            throw new ArgumentException("Date of birth is required.");
        }
    }

    private void ValidateLegalEntity(string? cnpj, string? companyName)
    {
        if (string.IsNullOrEmpty(cnpj))
        {
            throw new ArgumentException("CNPJ is required.");
        }

        if (string.IsNullOrEmpty(companyName))
        {
            throw new ArgumentException("Company name is required.");
        }
    }
}
