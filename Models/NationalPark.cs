using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class NationalPark
    {
        public int NationalParkId { get; set; } //Primary Key

        [Required]
        public string ParkName { get; set; } = string.Empty;

        [Required]
        public string ParkState { get; set; } = string.Empty;

        public List<UserNationalParks> UserNationalParks { get; set; } = default!; // Navigation Property. National Parks can have MANY UserNationalParks
    }

    public class UserNationalParks
    {
        public int NationalParkId { get; set; } //Composite Primary Key, Foreign Key 1
        public int UserDataId { get; set; } //Composite Primary Key, Foreign Key 1

        public NationalPark NationalPark { get; set; } = default!; //Navigation Property. One Park per UserNationalPark
        public UserData UserData { get; set; } = default!; //Navigation Property. One User per UserNationalPark
    }
}
