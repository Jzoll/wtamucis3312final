using System.ComponentModel.DataAnnotations;
using System;

namespace Final.Models

//Entity Class
public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public List<UserNationalPark>? UserNationalParks { get; set; } = default!; // Navigation Property. User can visit MANY NationalParks
}
