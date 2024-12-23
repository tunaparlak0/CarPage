using System.ComponentModel.DataAnnotations;

public class Purchase
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } 

    [Required]
    public string Phone { get; set; }
}