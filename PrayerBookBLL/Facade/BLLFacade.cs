using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using PrayerBookBLL.Interfaces;
using PrayerBookBLL.Services;
using PrayerBookDAL.Interfaces;

[assembly: InternalsVisibleTo("PrayerBookBLLTest")]
namespace PrayerBookBLL.Facade
{
    public class BLLFacade : IBLLFacade
    {
        public IPrayerService PrayerService => new PrayerService(_facade);

        private readonly IDALFacade _facade;

        public BLLFacade(IDALFacade facade)
        {
            _facade = facade;
        }


    }
}
