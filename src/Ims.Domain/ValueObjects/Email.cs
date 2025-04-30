using System.Text.RegularExpressions;

public class Email
{
    public string Address { get; private set; } = string.Empty;

    private Email() { }

    public Email(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Email is required.");

        if (!Regex.IsMatch(address, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Email is not in a valid format.");

        Address = address;
    }
}