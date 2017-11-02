using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDALTest
{
    public interface IRepositoryTest
    {
        void CreateOne();
        void NotCreateOneParseNull();
        void GetAll();
        void GetOneByExistingId();
        void NotGetOneByNonExistingId();
        void DeleteOneWithExistingId();
        void NotDeleteOneWIthNonExistingId();

    }
}
