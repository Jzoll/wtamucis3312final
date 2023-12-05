using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (
                var context = new FinalDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<FinalDbContext>>()
                )
            )
            {
                if (context.UserData.Any())
                {
                    return;
                }

                List<NationalPark> nationalparks = new List<NationalPark>
                {
                    // Colorodo
                    new NationalPark { ParkName = "Bent's Old Fort NHS", ParkState = "Colorodo" },
                    new NationalPark
                    {
                        ParkName = "Black Canyon of the Gunnison NP",
                        ParkState = "Colorodo"
                    },
                    new NationalPark
                    {
                        ParkName = "Black Canyon of the Gunnison NP - North Rim",
                        ParkState = "Colorodo"
                    },
                    new NationalPark { ParkName = "Colorado NM", ParkState = "Colorodo" },
                    new NationalPark
                    {
                        ParkName = "Continental Divide NST",
                        ParkState = "Colorodo"
                    },
                    new NationalPark { ParkName = "Curecanti NRA", ParkState = "Colorodo" },
                    new NationalPark { ParkName = "Dinosaur NM", ParkState = "Colorodo" },
                    new NationalPark
                    {
                        ParkName = "Florissant Fossil Beds NM",
                        ParkState = "Colorodo"
                    },
                    new NationalPark
                    {
                        ParkName = "Great Sand Dunes NM & PRES",
                        ParkState = "Colorodo"
                    },
                    new NationalPark { ParkName = "Hovenweep NM", ParkState = "Colorodo" },
                    new NationalPark { ParkName = "Mesa Verde NP", ParkState = "Colorodo" },
                    new NationalPark { ParkName = "Rocky Mountain NP", ParkState = "Colorodo" },
                    new NationalPark
                    {
                        ParkName = "Sand Creek Massacre NHS",
                        ParkState = "Colorodo"
                    },
                    new NationalPark { ParkName = "South Park NHA", ParkState = "Colorodo" },
                    new NationalPark { ParkName = "Yucca House NM", ParkState = "Colorodo" },
                    // Utah
                    new NationalPark { ParkName = "Arches NP", ParkState = "Utah" },
                    new NationalPark { ParkName = "Bryce Canyon NP", ParkState = "Utah" },
                    new NationalPark { ParkName = "Canyonlands NP", ParkState = "Utah" },
                    new NationalPark { ParkName = "Capitol Reef NP", ParkState = "Utah" },
                    new NationalPark { ParkName = "Cedar Breaks NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Dinosaur NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Glen Canyon NRA", ParkState = "Utah" },
                    new NationalPark { ParkName = "Golden Spike NHP", ParkState = "Utah" },
                    new NationalPark { ParkName = "Hovenweep NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Natural Bridges NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Oregon NHT", ParkState = "Utah" },
                    new NationalPark { ParkName = "Rainbow Bridge NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Timpanogos Cave NM", ParkState = "Utah" },
                    new NationalPark { ParkName = "Zion NP", ParkState = "Utah" },
                    // Wyoming
                    new NationalPark { ParkName = "Bighorn Canyon NRA", ParkState = "Wyoming" },
                    new NationalPark { ParkName = "Devils Tower NM", ParkState = "Wyoming" },
                    new NationalPark { ParkName = "Fort Laramie NHS", ParkState = "Wyoming" },
                    new NationalPark { ParkName = "Fossil Butte NM", ParkState = "Wyoming" },
                    new NationalPark { ParkName = "Grand Teton NP", ParkState = "Wyoming" },
                    new NationalPark
                    {
                        ParkName = "John D. Rockefeller, Jr. Memorial Parkway",
                        ParkState = "Wyoming"
                    },
                    new NationalPark { ParkName = "Mormon Pioneer NHT", ParkState = "Wyoming" },
                    new NationalPark { ParkName = "Yellowstone NP", ParkState = "Wyoming" },
                    // South Dakota
                    new NationalPark { ParkName = "Badlands NP", ParkState = "South Dakota" },
                    new NationalPark { ParkName = "Jewel Cave NM", ParkState = "South Dakota" },
                    new NationalPark
                    {
                        ParkName = "Lewis and Clark NHT",
                        ParkState = "South Dakota"
                    },
                    new NationalPark
                    {
                        ParkName = "Minuteman Missile NHS",
                        ParkState = "South Dakota"
                    },
                    new NationalPark { ParkName = "Missouri NRR", ParkState = "South Dakota" },
                    new NationalPark
                    {
                        ParkName = "Mt. Rushmore N MEM",
                        ParkState = "South Dakota"
                    },
                    new NationalPark { ParkName = "Wind Cave NP", ParkState = "South Dakota" },
                    // North Dakota
                    new NationalPark
                    {
                        ParkName = "Fort Union Trading Post NHS",
                        ParkState = "North Dakota"
                    },
                    new NationalPark
                    {
                        ParkName = "International Peace Garden",
                        ParkState = "North Dakota"
                    },
                    new NationalPark
                    {
                        ParkName = "Knife River Indian Villages NHS",
                        ParkState = "North Dakota"
                    },
                    new NationalPark
                    {
                        ParkName = "Lewis and Clark NHT",
                        ParkState = "North Dakota"
                    },
                    new NationalPark
                    {
                        ParkName = "Theodore Roosevelt NP",
                        ParkState = "North Dakota"
                    },
                    // Montana
                    new NationalPark { ParkName = "Bear Paw Battlefield", ParkState = "Montana" },
                    new NationalPark { ParkName = "Big Hole NB", ParkState = "Montana" },
                    new NationalPark { ParkName = "Bighorn Canyon NRA", ParkState = "Montana" },
                    new NationalPark { ParkName = "Glacier NP", ParkState = "Montana" },
                    new NationalPark { ParkName = "Grant-Kohrs Ranch NHS", ParkState = "Montana" },
                    new NationalPark
                    {
                        ParkName = "Little Bighorn Battlefield",
                        ParkState = "Montana"
                    },
                    new NationalPark { ParkName = "Nez Perce NHP", ParkState = "Montana" },
                    new NationalPark { ParkName = "Yellowstone NP", ParkState = "Montana" }
                };
                context.AddRange(nationalparks);

                List<UserData> userDatas = new List<UserData>
                {
                    new UserData
                    {
                        FirstName = "Jo",
                        LastName = "Doe",
                        Email = "jo.doe@gmail.com",
                        Password = "password123"
                    },
                    new UserData
                    {
                        FirstName = "Jane",
                        LastName = "Smith",
                        Email = "jane.smith@outlook.com",
                        Password = "securepass456"
                    },
                    new UserData
                    {
                        FirstName = "Alice",
                        LastName = "Greene",
                        Email = "alice.greene@gmail.com",
                        Password = "alicesecret"
                    },
                    new UserData
                    {
                        FirstName = "Bob",
                        LastName = "Williams",
                        Email = "bob.williams@outlook.com",
                        Password = "bobssecurepass"
                    },
                    new UserData
                    {
                        FirstName = "Emily",
                        LastName = "Davis",
                        Email = "emily.davis@outlook.com",
                        Password = "emilyspassword"
                    },
                    new UserData
                    {
                        FirstName = "Chris",
                        LastName = "Miller",
                        Email = "chris.miller@gmail.com",
                        Password = "chrissuperpass"
                    },
                    new UserData
                    {
                        FirstName = "Grace",
                        LastName = "Taylor",
                        Email = "grace.taylor@gmail.com",
                        Password = "gracesecure123"
                    },
                    new UserData
                    {
                        FirstName = "Chloe",
                        LastName = "Brown",
                        Email = "chloe.brown@outlook.com",
                        Password = "michaelspass"
                    },
                    new UserData
                    {
                        FirstName = "Sophia",
                        LastName = "Clark",
                        Email = "sophia.clark@outlook.com",
                        Password = "sophiaspassword"
                    },
                    new UserData
                    {
                        FirstName = "David",
                        LastName = "Turner",
                        Email = "david.turner@outlook.com",
                        Password = "davidsecurepass"
                    }
                };
                context.AddRange(userDatas);

                List<UserNationalParks> userNationalParks = new List<UserNationalParks>
                {
                    new UserNationalParks { NationalParkId = 1, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 2, UserDataId = 2 },
                    new UserNationalParks { NationalParkId = 50, UserDataId = 3 },
                    new UserNationalParks { NationalParkId = 33, UserDataId = 4 },
                    new UserNationalParks { NationalParkId = 24, UserDataId = 5 },
                    new UserNationalParks { NationalParkId = 21, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 47, UserDataId = 7 },
                };
                context.AddRange(userNationalParks);

                context.SaveChanges();
            }
        }
    }
}
