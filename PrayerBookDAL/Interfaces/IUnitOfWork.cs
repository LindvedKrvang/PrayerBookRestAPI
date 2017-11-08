using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPrayerRepository PrayerRepository { get; }
        IResponseRepository ResponseRepository { get; }

        int Complete();
    }
}
