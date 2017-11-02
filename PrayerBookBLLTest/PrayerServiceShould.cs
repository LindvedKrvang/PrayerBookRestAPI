using System;
using System.Collections.Generic;
using Moq;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookBLL.Services;
using PrayerBookDAL.Entities;
using PrayerBookDAL.Interfaces;
using Xunit;

namespace PrayerBookBLLTest
{
    public class PrayerServiceShould : AServiceTest
    {
        private readonly Mock<IPrayerRepository> _mockPrayerRepo;
        private readonly IPrayerService _service;

        public PrayerServiceShould()
        {
            _mockPrayerRepo = new Mock<IPrayerRepository>();
            MockUOW.Setup(uow => uow.PrayerRepository).Returns(_mockPrayerRepo.Object);
            _service = new PrayerService(MockDALFacade.Object);
        }

        [Fact]
        public override void CreateOne()
        {
            _mockPrayerRepo.Setup(repo => repo.Create(It.IsAny<Prayer>())).Returns(new Prayer());
            var result = _service.Create(new PrayerBO());
            Assert.NotNull(result);
        }

        [Fact]
        public override void NotCreateOneParseNull()
        {
            _mockPrayerRepo.Setup(repo => repo.Create(It.IsAny<Prayer>())).Returns(new Prayer());
            var result = _service.Create(null);
            Assert.Null(result);
        }
        [Fact]
        public override void GetAll()
        {
            _mockPrayerRepo.Setup(repo => repo.GetAll()).Returns(new List<Prayer> {new Prayer(), new Prayer()});
            var result = _service.GetAll();
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
        [Fact]
        public override void GetOneByExistingId()
        {
            const int id = 1;
            _mockPrayerRepo.Setup(repo => repo.Get(id)).Returns(new Prayer {Id = id});

            var result = _service.Get(id);
            Assert.NotNull(result);
        }
        [Fact]
        public override void NotGetOneByNonExistingId()
        {
            _mockPrayerRepo.Setup(repo => repo.Get(It.IsAny<int>())).Returns(() => null);
            var nonExistingId = 0;
            var result = _service.Get(nonExistingId);
            Assert.Null(result);
        }
       [Fact]
        public override void DeleteByExistingId()
        {
            var id = 1;
            _mockPrayerRepo.Setup(repo => repo.Delete(id)).Returns(true);
            _mockPrayerRepo.Setup(repo => repo.Get(id)).Returns(new Prayer());

            var result = _service.Delete(id);

            Assert.True(result);
        }
        [Fact]
        public override void NotDeleteOneByNonExistingId()
        {
            var nonExistingId = 0;
            var result = _service.Delete(nonExistingId);
            Assert.False(result);
        }
        [Fact]
        public override void UpdateByExistingId()
        {
            //Something fishy with unitTesing this way...
            //You can't check if you actually made anye changes, since it always returns what you defined.
            var prayerBO = new PrayerBO{Id = 1, Subject = "Subject"};
            var newSubject = "New Subject";

            _mockPrayerRepo.Setup(repo => repo.Get(prayerBO.Id)).Returns(new Prayer{Id = prayerBO.Id, Subject = prayerBO.Subject});

            prayerBO.Subject = newSubject;
            var result = _service.Update(prayerBO);

            Assert.Contains(newSubject, result.Subject);

        }
        [Fact]
        public override void NotUpdateByNonExistingId()
        {
            var nonExistingId = 0;

            _mockPrayerRepo.Setup(repo => repo.Get(It.IsAny<int>())).Returns(() => null);

            var result = _service.Update(new PrayerBO{Id = nonExistingId});
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
