using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookDAL.Entities;

namespace PrayerBookBLL.Converters
{
    internal class PrayerConverter : IConverter<PrayerBO, Prayer>
    {
        public PrayerBO Convert(Prayer entity)
        {
            throw new NotImplementedException();
        }

        public Prayer Convert(PrayerBO bo)
        {
            throw new NotImplementedException();
        }
    }
}
