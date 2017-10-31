using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PrayerBookDAL.Context
{
    public class PrayerBookContext : DbContext
    {
        private static readonly DbContextOptions<PrayerBookContext> options =
            new DbContextOptionsBuilder<PrayerBookContext>().UseInMemoryDatabase("TheDB").Options;

        public PrayerBookContext() : base(options)
        {
            
        }
    }
}
