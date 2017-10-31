using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.UOW;

namespace PrayerBookDAL.Facade
{
    public class DALFacade : IDALFacade
    {
        private readonly PrayerBookContext _context;

        public IUnitOfWork UnitOfWork => new UnitOfWork(_context);

        public DALFacade(PrayerBookContext context)
        {
            _context = context;
        }
    }
}
