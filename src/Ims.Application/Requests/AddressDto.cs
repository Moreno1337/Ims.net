namespace Ims.Application.Requests;

public class AddressDto
{
    public string? Country { get; set; } = string.Empty;
    public string? State { get; set; } = string.Empty;
    public string? City { get; set; } = string.Empty;
    public string? ZipCode { get; set; } = string.Empty;
    public string? Street { get; set; } = string.Empty;
    public string? Number { get; set; } = string.Empty;
    public string? Neighborhood { get; set; }
    public string? Complement { get; set; }
}
