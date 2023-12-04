using System;

namespace Final.Models
{
    {
        public class Context : DbContext{
            public NationalParkDbContext (DbContextOptions<Context> options)
            :base(options)
            {
            }
        
        // protected override goes here

            public DbSet<NationalPark> NationalParks {get;set;} = default!;
        }
    }
}