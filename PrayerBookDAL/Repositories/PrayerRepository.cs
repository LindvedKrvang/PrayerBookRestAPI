using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;

namespace PrayerBookDAL.Repositories
{
    internal class PrayerRepository : IPrayerRepository
    {
        private readonly PrayerBookContext _context;

        public PrayerRepository(PrayerBookContext context)
        {
            _context = context;
        }

        public Prayer Create(Prayer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prayer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Prayer Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
