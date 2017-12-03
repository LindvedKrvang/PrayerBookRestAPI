using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PrayerBookDAL.Entities;

namespace PrayerBookDAL.Context
{
    public class PrayerBookContext : DbContext
    {
        public PrayerBookContext(DbContextOptions<PrayerBookContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Prayer> Prayers { get; set; }
        public  DbSet<Response> Responses { get; set; }
    }
}
