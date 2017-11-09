using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using PrayerBookBLL.Interfaces;
using PrayerBookBLL.Services;
using PrayerBookDAL.Interfaces;

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

        public override void CreateOne()
        {
            throw new NotImplementedException();
        }

        public override void NotCreateOneParseNull()
        {
            throw new NotImplementedException();
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetOneByExistingId()
        {
            throw new NotImplementedException();
        }

        public override void NotGetOneByNonExistingId()
        {
            throw new NotImplementedException();
        }

        public override void DeleteByExistingId()
        {
            throw new NotImplementedException();
        }

        public override void NotDeleteOneByNonExistingId()
        {
            throw new NotImplementedException();
        }

        public override void UpdateByExistingId()
        {
            throw new NotImplementedException();
        }

        public override void NotUpdateByNonExistingId()
        {
            throw new NotImplementedException();
        }

        public override void NotUpdateByNull()
        {
            throw new NotImplementedException();
        }
    }
}
