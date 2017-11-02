using System;
using System.Linq;
using PrayerBookDAL.Context;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.Repositories;
using PrayerBookDALTest.Helpers;
using Xunit;

namespace PrayerBookDALTest
{
    public class PrayerRepositoryShould : IRepositoryTest
    {
        private readonly PrayerBookContext _context;
        private readonly IPrayerRepository _repository;

        public PrayerRepositoryShould()
        {
            _context = TestContext.Context;
            _repository = new PrayerRepository(_context);
        }

        private Prayer CreateMockPrayer()
        {
            var mock = new Prayer{ Subject = "Test"};
            var createdPrayer = _repository.Create(mock);
            _context.SaveChanges();
            return createdPrayer;
        }

        [Fact]
        public void CreateOne()
        {
            var entity = new Prayer {Subject = "TestCreate"};
            var createdEntity = _repository.Create(entity);
            _context.SaveChanges();
            Assert.NotNull(createdEntity);
        }
        [Fact]
        public void NotCreateOneParseNull()
        {
            var createdEntity = _repository.Create(null);
            Assert.Null(createdEntity);
        }
        [Fact]
        public void GetAll()
        {
            CreateMockPrayer();
            CreateMockPrayer();
            var entities = _repository.GetAll();
            Assert.Equal(2, entities.Count());
        }
        [Fact]
        public void GetOneByExistingId()
        {
            var createdEntity = CreateMockPrayer();
            CreateMockPrayer();
            CreateMockPrayer();
            var foundEntity = _repository.Get(createdEntity.Id);
            Assert.NotNull(foundEntity);
            Assert.Equal(createdEntity.Id, foundEntity.Id);
        }
        [Fact]
        public void NotGetOneByNonExistingId()
        {
            var foundEntity = _repository.Get(0);
            Assert.Null(foundEntity);
        }
        [Fact]
        public void DeleteOneWithExistingId()
        {
            var entityToDelete = CreateMockPrayer();
            var deleteSuccesfull = _repository.Delete(entityToDelete.Id);
            Assert.True(deleteSuccesfull);
        }
        [Fact]
        public void NotDeleteOneWIthNonExistingId()
        {
            var deleteSuccesfull = _repository.Delete(0);
            Assert.False(deleteSuccesfull);
        }

        [Fact]
        public void CITestProject()
        {
            Assert.True(true);
        }
    }
}
