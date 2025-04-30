using Ims.Domain.Entities;
using Ims.Application.Requests;

namespace Ims.Application.Clients.Requests;

public class AddClientRequest
{
    public ClientType Type { get; set; }
    public string? CPF { get; set; }
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? CNPJ { get; set; }
    public string? CompanyName { get; set; }
    public string? FantasyName { get; set; }
    public string? StateRegistration { get; set; }
    public int? BillingTerm { get; set; }
    public decimal? Fees { get; set; }
    public decimal? Fine { get; set; }
    public string? Telephone { get; set; }
    public string? Cellphone { get; set; }
    public required AddressDto Address { get; set; }
    public string? Observations { get; set; }
    public List<string>? EmailList { get; set; } = new();
}
