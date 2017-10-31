using System;
using PrayerBookDAL.Context;
using PrayerBookDAL.Repositories;
using PrayerBookDALTest.Helpers;
using Xunit;

namespace PrayerBookDALTest
{
    public class PrayerRepositoryShould : IRepositoryTest
    {
        private readonly PrayerBookContext _context;
        private readonly PrayerRepository _repository;

        public PrayerRepositoryShould()
        {
            _context = TestContext.Context;
            _repository = new PrayerRepository(_context);
        }

        [Fact]
        public void CreateOne()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void NotCreateOneParsingNull()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetOneByExistingId()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void NotGetOneByNonExistingId()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void DeleteByExistingId()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void NotDeleteByNonExistingId()
        {
            throw new NotImplementedException();
        }
    }
}
