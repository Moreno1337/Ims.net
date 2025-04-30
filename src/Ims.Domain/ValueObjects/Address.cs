namespace Ims.Domain.ValueObjects;

public class Address
{
    public required string Country { get; init; }
    public required string State { get; init; }
    public required string City { get; init; }
    public required string ZipCode { get; init; }
    public required string Neighborhood { get; init; }
    public required string Street { get; init; }
    public required string Number { get; init; }
    public required string? Complement { get; init; }

    private Address() { }

    public Address(
        string country,
        string state,
        string city,
        string zipCode,
        string neighborhood,
        string street,
        string number,
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
