using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPage.Models
{
    
using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
}