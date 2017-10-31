using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDALTest
{
    public interface IRepositoryTest
    {
        void CreateOne();

        void NotCreateOneParsingNull();

        void GetAll();

        void GetOneByExistingId();

        void NotGetOneByNonExistingId();

        void DeleteByExistingId();

        void NotDeleteByNonExistingId();

    }
}
