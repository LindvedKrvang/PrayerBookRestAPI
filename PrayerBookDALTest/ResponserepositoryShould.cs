using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrayerBookDAL.Context;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;
using PrayerBookDAL.Repositories;
using PrayerBookDALTest.Helpers;
using Xunit;

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

        private Response CreateMockResponse()
        {
            var mock = new Response{Answer = "TestAnser", PrayerId = 1, ResponseNumber = 1};
            var createdResponse = _repository.Create(mock);
            _context.SaveChanges();
            return createdResponse;
        }

        [Fact]
        public void CreateOne()
        {
            var createdResponse = CreateMockResponse();
            Assert.NotNull(createdResponse);
        }
        [Fact]
        public void NotCreateOneParseNull()
        {
            var createdResponse = _repository.Create(null);
            Assert.Null(createdResponse);
        }
        [Fact]
        public void GetAll()
        {
            CreateMockResponse();
            CreateMockResponse();
            CreateMockResponse();

            var result = _repository.GetAll();
            Assert.NotNull(result);
            var expectedResult = 3;
            Assert.Equal(expectedResult, result.Count());
        }
        [Fact]

        public void GetOneByExistingId()
        {
            CreateMockResponse();
            var createdresponse = CreateMockResponse();
            CreateMockResponse();

            var result = _repository.Get(createdresponse.Id);

            Assert.NotNull(result);
            Assert.Equal(createdresponse.Id, result.Id);
        }
        [Fact]

        public void NotGetOneByNonExistingId()
        {
            var id = 0;
            var result = _repository.Get(0);

            Assert.Null(result);
        }

        [Fact]
        public void DeleteOneWithExistingId()
        {
            var createdResponse = CreateMockResponse();
            _repository.Delete(createdResponse.Id);
            _context.SaveChanges();
            var listAfterDelete = _repository.GetAll();

            Assert.DoesNotContain(createdResponse, listAfterDelete);
        }
        [Fact]

        public void NotDeleteOneWIthNonExistingId()
        {
            var isDeleted = _repository.Delete(0);
            Assert.False(isDeleted);
        }
    }
}
