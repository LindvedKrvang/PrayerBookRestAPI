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
            if (entity == null) return null;
            return new PrayerBO
            {
                Id = entity.Id,
                Subject = entity.Subject
            };
        }

        public Prayer Convert(PrayerBO bo)
        {
            if (bo == null) return null;
            return new Prayer
            {
                Id = bo.Id,
                Subject = bo.Subject
            };
        }
    }
}
