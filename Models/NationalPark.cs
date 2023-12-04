using System;

namespace Final.Models
{
    public class NationalPark
    {
        public int NationalParkId { get; set; } //Primary Key
        public string ParkName { get; set; } = string.Empty;
        public string ParkLocation { get; set; } = string.Empty;
    }

    public class UserNationalParks
    {
        public int NationalParkId { get; set; } //Composite Primary Key, Foreign Key 1
        public int UserId { get; set; } //Composite Primary Key, Foreign Key 1

        public NationalPark NationalPark { get; set; } = default!; //Navigation Property. One Park per UserNationalPark
        public UserData UserData { get; set; } = default!; //Navigation Property. One User per UserNationalPark
    }
}
