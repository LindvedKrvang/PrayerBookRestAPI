using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.Repositories;
using PrayerBookDALTest.Helpers;

namespace PrayerBookDALTest
{
    public class ResponseRepositoryShould : IRepositoryTest
    {
        private PrayerBookContext _context;
        private IResponseRepository _repository;

        public ResponseRepositoryShould()
        {
            _context = TestContext.Context;
            _repository = new ResponseRepository(_context);
        }

        public void CreateOne()
        {
            throw new NotImplementedException();
        }

        public void NotCreateOneParseNull()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetOneByExistingId()
        {
            throw new NotImplementedException();
        }

        public void NotGetOneByNonExistingId()
        {
            throw new NotImplementedException();
        }

        public void DeleteOneWithExistingId()
        {
            throw new NotImplementedException();
        }

        public void NotDeleteOneWIthNonExistingId()
        {
            throw new NotImplementedException();
        }
    }
}
