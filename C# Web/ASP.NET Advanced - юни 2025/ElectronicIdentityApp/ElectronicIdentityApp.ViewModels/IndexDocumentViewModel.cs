namespace ElectronicIdentityApp.ViewModels;

public class IndexDocumentViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;
    public string Nationality { get; set; } = null!;
    public string Address { get; set; } = null!;
    public DateTime IssuedOn { get; set; }
    public DateTime ExpiredOn { get; set; }
    public bool IsValid { get; set; }

    public string? ImageUrl { get; set; }


}