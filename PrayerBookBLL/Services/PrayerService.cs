using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookDAL.Interfaces;

namespace PrayerBookBLL.Services
{
    internal class PrayerService : IPrayerService
    {
        private readonly IDALFacade _facade;

        public PrayerService(IDALFacade facade)
        {
            _facade = facade;
        }

        public PrayerBO Create(PrayerBO businessObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrayerBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public PrayerBO Get(int id)
        {
            throw new NotImplementedException();
        }

        public PrayerBO Update(PrayerBO businessObject)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
