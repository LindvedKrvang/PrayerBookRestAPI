using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using PrayerBookDAL.Interfaces;

namespace PrayerBookBLLTest
{
    public abstract class AServiceTest
    {
        protected readonly Mock<IDALFacade> MockDALFacade = new Mock<IDALFacade>();
        protected readonly Mock<IUnitOfWork> MockUOW = new Mock<IUnitOfWork>();

        protected AServiceTest()
        {
            MockDALFacade.Setup(dal => dal.UnitOfWork).Returns(MockUOW.Object);
        }

        public abstract void CreateOne();
        public abstract void NotCreateOneParseNull();
        public abstract void GetAll();
        public abstract void GetOneByExistingId();
        public abstract void NotGetOneByNonExistingId();
        public abstract void DeleteByExistingId();
        public abstract void NotDeleteOneByNonExistingId();
        public abstract void UpdateByExistingId();
        public abstract void NotUpdateByNonExistingId();
        public abstract void NotUpdateByNull();
    }
}
