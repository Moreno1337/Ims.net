using Ims.Domain.ValueObjects;

namespace Ims.Domain.Entities;

public enum ClientType { NaturalPerson, LegalEntity }

public class Client
{
    public int Id { get; init; }
    public ClientType Type { get; init; }
    public string? CPF { get; init; }
    public string? Name { get; init; }
    public bool Status { get; init; }
    public DateTime? DateOfBirth { get; init; }
    public string? StateRegistration { get; init; }
    public string? CNPJ { get; init; }
    public string? CompanyName { get; init; }
    public string? FantasyName { get; init; }
    public int BillingTerm { get; init; }
    public string? Telephone { get; init; }
    public string? Cellphone { get; init; }
    public Address? Address { get; init; }
    public string? Observations { get; init; }
    public List<string>? EmailList { get; init; }
    public decimal Fees { get; init; }
    public decimal Fine { get; init; }
    public decimal TotalValueInDebit { get; init; }

    private Client() { }

    public Client(
        int id,
        ClientType type,
        string? cpf,
        string? name,
        bool status,
        DateTime? dateOfBirth,
        string? stateRegistration,
        string? cnpj,
        string? companyName,
        string? fantasyName,
        int billingTerm,
        string? telephone,
        string? cellphone,
        Address address,
        string? observations,
        List<string>? emailList,
        decimal fees,
        decimal fine,
        decimal totalValueInDebit
    )
    {
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
        this.TotalValueInDebit = totalValueInDebit;
    }
}
