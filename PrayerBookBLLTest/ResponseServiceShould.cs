using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookBLL.Services;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;
using Xunit;

namespace PrayerBookBLLTest
{
    public class ResponseServiceShould : AServiceTest
    {
        private readonly Mock<IResponseRepository> _mockResponseRepo;
        private readonly IResponseService _service;

        public ResponseServiceShould()
        {
            _mockResponseRepo = new Mock<IResponseRepository>();
            MockUOW.Setup(uow => uow.ResponseRepository).Returns(_mockResponseRepo.Object);
            _service = new ResponseService(MockDALFacade.Object);
        }

        [Fact]
        public override void CreateOne()
        {
            var testResponse = new ResponseBO {Answer = "TestTwo"};
            _mockResponseRepo.Setup(r => r.Create(It.IsAny<Response>()))
                .Returns(new Response {PrayerId = 1, Answer = "Test"});

            var result = _service.Create(testResponse);

            Assert.NotNull(result);
        }
        [Fact]
        public override void NotCreateOneParseNull()
        {
            _mockResponseRepo.Setup(r => r.Create(It.IsAny<Response>())).Returns(new Response());

            var result = _service.Create(null);

            Assert.Null(result);
        }
        [Fact]
        public override void GetAll()
        {
            _mockResponseRepo.Setup(r => r.GetAll()).Returns(new List<Response>{new Response(), new Response()});

            var result = _service.GetAll();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
        [Fact]
        public override void GetOneByExistingId()
        {
            var response = new Response{Id = 1, Answer = "Test"};
            _mockResponseRepo.Setup(r => r.Get(response.Id)).Returns(response);

            var result = _service.Get(response.Id);

            Assert.NotNull(result);
            Assert.Equal(response.Id, result.Id);
        }
        [Fact]
        public override void NotGetOneByNonExistingId()
        {
            _mockResponseRepo.Setup(r => r.Get(0)).Returns(() => null);

            var result = _service.Get(0);

            Assert.Null(result);
        }
        [Fact]
        public override void DeleteByExistingId()
        {
            var response = new Response {Id = 1, Answer = "Test"};
            _mockResponseRepo.Setup(r => r.Delete(response.Id)).Returns(true);

            var result = _service.Delete(response.Id);

            Assert.True(result);
        }
        [Fact]
        public override void NotDeleteOneByNonExistingId()
        {
            _mockResponseRepo.Setup(r => r.Delete(0)).Returns(false);

            var result = _service.Delete(0);

            Assert.False(result);
        }
        [Fact]
        public override void UpdateByExistingId()
        {
            var response = new Response{Id = 1, Answer = "Test", PrayerId = 2, ResponseNumber = 4};
            const string newAnswer = "New Test";
            const int newPrayerId = 1;
            const int newResponseNumber = 5;
            _mockResponseRepo.Setup(r => r.Get(response.Id)).Returns(response);

            var responseToUpdate = _service.Get(response.Id);
            responseToUpdate.Answer = newAnswer;
            responseToUpdate.PrayerId = newPrayerId;
            responseToUpdate.ResponseNumber = newResponseNumber;
            var result = _service.Update(responseToUpdate);

            Assert.Equal(newAnswer, result.Answer);
            Assert.Equal(newPrayerId, result.PrayerId);
            Assert.Equal(newResponseNumber, result.ResponseNumber);
        }
        [Fact]
        public override void NotUpdateByNonExistingId()
        {
            _mockResponseRepo.Setup(r => r.Get(0)).Returns(() => null);

            var result = _service.Update(new ResponseBO{Id = 0});

            Assert.Null(result);
        }
        [Fact]
        public override void NotUpdateByNull()
        {
            var result = _service.Update(null);

            Assert.Null(result);
        }
    }
}
