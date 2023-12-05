using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    //Entity Class
    public class UserData
    {
        public int UserDataId { get; set; } //Primary Key: must be same as Class name + id

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
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
