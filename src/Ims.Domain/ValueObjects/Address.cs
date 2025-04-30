namespace Ims.Domain.ValueObjects;

public class Address
{
    public string? Country { get; private set; }
    public string? State { get; private set; }
    public string? City { get; private set; }
    public string? ZipCode { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? Street { get; private set; }
    public string? Number { get; private set; }
    public string? Complement { get; private set; }

    private Address() { }

    public Address(
        string? country,
        string? state,
        string? city,
        string? zipCode,
        string? neighborhood,
        string? street,
        string? number,
        string? complement
    )
    {
        Country = country;
        State = state;
        City = city;
        ZipCode = zipCode;
        Neighborhood = neighborhood;
        Street = street;
        Number = number;
        Complement = complement;
    }
}
