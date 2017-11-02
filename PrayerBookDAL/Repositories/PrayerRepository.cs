using System;
using System.Collections.Generic;
using System.Linq;
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
            if (entity == null) return null;
            return _context.Prayers.Add(entity).Entity;
        }

        public IEnumerable<Prayer> GetAll()
        {
            return _context.Prayers.ToList();
        }

        public Prayer Get(int id)
        {
            return _context.Prayers.FirstOrDefault(prayer => prayer.Id == id);
        }

        public bool Delete(int id)
        {
            var prayerToDelete = Get(id);
            if (prayerToDelete == null) return false;
            var deletedEntity = _context.Prayers.Remove(prayerToDelete);
            if (deletedEntity == null) return false;
            return true;
        }
    }
}
