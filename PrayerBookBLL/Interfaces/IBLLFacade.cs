using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookBLL.Interfaces
{
    public interface IBLLFacade
    {
        IPrayerService PrayerService { get;  }
        IResponseService ResponseService { get; }
    }
}
