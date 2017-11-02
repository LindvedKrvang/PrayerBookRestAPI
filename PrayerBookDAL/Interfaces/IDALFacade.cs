using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDAL.Interfaces
{
    public interface IDALFacade
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
