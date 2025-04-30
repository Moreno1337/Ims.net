using Ims.Domain.Entities;
using Ims.Application.Requests;

namespace Ims.Application.Clients.Requests;

public class AddClientRequest
{
    public ClientType Type { get; set; }
    public string? CPF { get; set; }
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? StateRegistration { get; set; }
    public string? CNPJ { get; set; }
    public string? CompanyName { get; set; }
    public string? FantasyName { get; set; }
    public int BillingTerm { get; set; }
    public string? Telephone { get; set; }
    public string? Cellphone { get; set; }
    public AddressDto Address { get; set; } = null!;
    public List<string> Emails { get; set; } = new();
    public string? Observations { get; set; }
    public List<string>? EmailList { get; set; }
    public decimal Fees { get; set; }
    public decimal Fine { get; set; }
    public decimal TotalValueInDebit { get; set; }
}
