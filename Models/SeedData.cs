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
                    new NationalPark
                    {
                        ParkName = "Bent's Old Fort NHS",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Bent's Old Fort National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "Black Canyon of the Gunnison NP",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Black Canyon of the Gunnison National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Black Canyon of the Gunnison NP - North Rim",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Black Canyon of the Gunnison National Park - North Rim"
                    },
                    new NationalPark
                    {
                        ParkName = "Colorado NM",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Colorado National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Continental Divide NST",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NST",
                        ParkProperName = "Continental Divide National Scenic Trail"
                    },
                    new NationalPark
                    {
                        ParkName = "Curecanti NRA",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NRA",
                        ParkProperName = "Curecanti National Recreation Area"
                    },
                    new NationalPark
                    {
                        ParkName = "Dinosaur NM",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Dinosaur National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Florissant Fossil Beds NM",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Florissant Fossil Beds National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Great Sand Dunes NM & PRES",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM & PRES",
                        ParkProperName = "Great Sand Dunes National Monument & Preserve"
                    },
                    new NationalPark
                    {
                        ParkName = "Hovenweep NM",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Hovenweep National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Mesa Verde NP",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Mesa Verde National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Rocky Mountain NP",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Rocky Mountain National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Sand Creek Massacre NHS",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Sand Creek Massacre National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "South Park NHA",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NHA",
                        ParkProperName = "South Park National Heritage Area"
                    },
                    new NationalPark
                    {
                        ParkName = "Yucca House NM",
                        ParkState = "Colorado",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Yucca House National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Bear Paw Battlefield",
                        ParkState = "Montana",
                        ParkAbbreviation = "",
                        ParkProperName = "Bear Paw Battlefield"
                    },
                    new NationalPark
                    {
                        ParkName = "Big Hole NB",
                        ParkState = "Montana",
                        ParkAbbreviation = "NB",
                        ParkProperName = "Big Hole National Battlefield"
                    },
                    new NationalPark
                    {
                        ParkName = "Bighorn Canyon NRA",
                        ParkState = "Montana",
                        ParkAbbreviation = "NRA",
                        ParkProperName = "Bighorn Canyon National Recreation Area"
                    },
                    new NationalPark
                    {
                        ParkName = "Glacier NP",
                        ParkState = "Montana",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Glacier National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Grant-Kohrs Ranch NHS",
                        ParkState = "Montana",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Grant-Kohrs Ranch National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "Little Bighorn Battlefield",
                        ParkState = "Montana",
                        ParkAbbreviation = "",
                        ParkProperName = "Little Bighorn Battlefield"
                    },
                    new NationalPark
                    {
                        ParkName = "Nez Perce NHP",
                        ParkState = "Montana",
                        ParkAbbreviation = "NHP",
                        ParkProperName = "Nez Perce National Historical Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Yellowstone NP",
                        ParkState = "Montana",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Yellowstone National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Fort Union Trading Post NHS",
                        ParkState = "North Dakota",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Fort Union Trading Post National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "International Peace Garden",
                        ParkState = "North Dakota",
                        ParkAbbreviation = "",
                        ParkProperName = "International Peace Garden"
                    },
                    new NationalPark
                    {
                        ParkName = "Knife River Indian Villages NHS",
                        ParkState = "North Dakota",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Knife River Indian Villages National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "Lewis and Clark NHT",
                        ParkState = "North Dakota",
                        ParkAbbreviation = "NHT",
                        ParkProperName = "Lewis and Clark National Historic Trail"
                    },
                    new NationalPark
                    {
                        ParkName = "Theodore Roosevelt NP",
                        ParkState = "North Dakota",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Theodore Roosevelt National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Badlands NP",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Badlands National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Jewel Cave NM",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Jewel Cave National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Lewis and Clark NHT",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NHT",
                        ParkProperName = "Lewis and Clark National Historic Trail"
                    },
                    new NationalPark
                    {
                        ParkName = "Minuteman Missile NHS",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Minuteman Missile National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "Missouri NRR",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NRR",
                        ParkProperName = "Missouri National Recreational River"
                    },
                    new NationalPark
                    {
                        ParkName = "Mt. Rushmore N MEM",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "N MEM",
                        ParkProperName = "Mount Rushmore National Memorial"
                    },
                    new NationalPark
                    {
                        ParkName = "Wind Cave NP",
                        ParkState = "South Dakota",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Wind Cave National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Arches NP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Arches National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Bryce Canyon NP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Bryce Canyon National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Canyonlands NP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Canyonlands National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Capitol Reef NP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Capitol Reef National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Cedar Breaks NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Cedar Breaks National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Dinosaur NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Dinosaur National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Glen Canyon NRA",
                        ParkState = "Utah",
                        ParkAbbreviation = "NRA",
                        ParkProperName = "Glen Canyon National Recreation Area"
                    },
                    new NationalPark
                    {
                        ParkName = "Golden Spike NHP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NHP",
                        ParkProperName = "Golden Spike National Historical Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Hovenweep NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Hovenweep National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Natural Bridges NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Natural Bridges National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Oregon NHT",
                        ParkState = "Utah",
                        ParkAbbreviation = "NHT",
                        ParkProperName = "Oregon National Historic Trail"
                    },
                    new NationalPark
                    {
                        ParkName = "Rainbow Bridge NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Rainbow Bridge National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Timpanogos Cave NM",
                        ParkState = "Utah",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Timpanogos Cave National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Zion NP",
                        ParkState = "Utah",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Zion National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "Bighorn Canyon NRA",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NRA",
                        ParkProperName = "Bighorn Canyon National Recreation Area"
                    },
                    new NationalPark
                    {
                        ParkName = "Devils Tower NM",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Devils Tower National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Fort Laramie NHS",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NHS",
                        ParkProperName = "Fort Laramie National Historic Site"
                    },
                    new NationalPark
                    {
                        ParkName = "Fossil Butte NM",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NM",
                        ParkProperName = "Fossil Butte National Monument"
                    },
                    new NationalPark
                    {
                        ParkName = "Grand Teton NP",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Grand Teton National Park"
                    },
                    new NationalPark
                    {
                        ParkName = "John D. Rockefeller, Jr. Memorial PKWY",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "PKWY",
                        ParkProperName = "John D. Rockefeller, Jr. Memorial Parkway"
                    },
                    new NationalPark
                    {
                        ParkName = "Mormon Pioneer NHT",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NHT",
                        ParkProperName = "Mormon Pioneer National Historic Trail"
                    },
                    new NationalPark
                    {
                        ParkName = "Yellowstone NP",
                        ParkState = "Wyoming",
                        ParkAbbreviation = "NP",
                        ParkProperName = "Yellowstone National Park"
                    }
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
                    },
                    new UserData
                    {
                        FirstName = "Robin",
                        LastName = "Woods",
                        Email = "robin.woods@gmail.com",
                        Password = "woodslover123"
                    },
                    new UserData
                    {
                        FirstName = "Lily",
                        LastName = "Meadow",
                        Email = "lily.meadow@outlook.com",
                        Password = "meadowview456"
                    },
                    new UserData
                    {
                        FirstName = "River",
                        LastName = "Stone",
                        Email = "river.stone@gmail.com",
                        Password = "stoneriver789"
                    },
                    new UserData
                    {
                        FirstName = "Sky",
                        LastName = "Falconer",
                        Email = "sky.falconer@outlook.com",
                        Password = "flyinghigh123"
                    },
                    new UserData
                    {
                        FirstName = "Ocean",
                        LastName = "Breeze",
                        Email = "ocean.breeze@gmail.com",
                        Password = "breezywaves456"
                    },
                    new UserData
                    {
                        FirstName = "Flora",
                        LastName = "Blossom",
                        Email = "flora.blossom@outlook.com",
                        Password = "flowerpower789"
                    },
                    new UserData
                    {
                        FirstName = "Stone",
                        LastName = "Mountain",
                        Email = "stone.mountain@gmail.com",
                        Password = "mountainhiker123"
                    },
                    new UserData
                    {
                        FirstName = "Meadow",
                        LastName = "Dew",
                        Email = "meadow.dew@outlook.com",
                        Password = "dewdrop456"
                    },
                    new UserData
                    {
                        FirstName = "Sunny",
                        LastName = "Meadow",
                        Email = "sunny.meadow@gmail.com",
                        Password = "sunshinemeadow789"
                    },
                    new UserData
                    {
                        FirstName = "Forest",
                        LastName = "Walker",
                        Email = "forest.walker@outlook.com",
                        Password = "naturetrail123"
                    }
                };
                context.AddRange(userDatas);

                List<UserNationalParks> userNationalParks = new List<UserNationalParks>
                {
                    new UserNationalParks { NationalParkId = 1, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 2, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 3, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 4, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 5, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 6, UserDataId = 1 },
                    new UserNationalParks { NationalParkId = 2, UserDataId = 2 },
                    new UserNationalParks { NationalParkId = 3, UserDataId = 2 },
                    new UserNationalParks { NationalParkId = 4, UserDataId = 2 },
                    new UserNationalParks { NationalParkId = 5, UserDataId = 2 },
                    new UserNationalParks { NationalParkId = 50, UserDataId = 3 },
                    new UserNationalParks { NationalParkId = 33, UserDataId = 4 },
                    new UserNationalParks { NationalParkId = 24, UserDataId = 5 },
                    new UserNationalParks { NationalParkId = 21, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 2, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 3, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 4, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 5, UserDataId = 6 },
                    new UserNationalParks { NationalParkId = 2, UserDataId = 7 },
                    new UserNationalParks { NationalParkId = 3, UserDataId = 7 },
                    new UserNationalParks { NationalParkId = 4, UserDataId = 7 },
                    new UserNationalParks { NationalParkId = 5, UserDataId = 7 },
                    new UserNationalParks { NationalParkId = 55, UserDataId = 7 },
                    new UserNationalParks { NationalParkId = 55, UserDataId = 8 },
                    new UserNationalParks { NationalParkId = 55, UserDataId = 9 },
                    new UserNationalParks { NationalParkId = 55, UserDataId = 10 },
                    new UserNationalParks { NationalParkId = 47, UserDataId = 13 },
                    new UserNationalParks { NationalParkId = 47, UserDataId = 14 },
                    new UserNationalParks { NationalParkId = 47, UserDataId = 15 },
                    new UserNationalParks { NationalParkId = 16, UserDataId = 16 },
                    new UserNationalParks { NationalParkId = 16, UserDataId = 17 },
                    new UserNationalParks { NationalParkId = 16, UserDataId = 18 },
                    new UserNationalParks { NationalParkId = 47, UserDataId = 18 },
                };
                context.AddRange(userNationalParks);

                context.SaveChanges();
            }
        }
    }
}
