using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    //Entity Class
    public class UserData
    {
        public int UserDataId { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [EmailAddress]
        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;

        public List<UserNationalParks> UserNationalParks { get; set; } = default!; // Navigation Property. User can visit MANY NationalParks
    }
}
