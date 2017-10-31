using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PrayerBookDAL.Context;

namespace PrayerBookDALTest.Helpers
{
    public static class TestContext
    {
        public static PrayerBookContext Context => new PrayerBookContext(new DbContextOptionsBuilder<PrayerBookContext>()
            .UseInMemoryDatabase($"{Guid.NewGuid()}")
            .Options);
    }
}
