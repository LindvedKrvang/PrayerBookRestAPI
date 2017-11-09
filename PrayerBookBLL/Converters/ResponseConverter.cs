using System;
using System.Collections.Generic;
using System.Text;
using PrayerBookBLL.BusinessObjects;
using PrayerBookBLL.Interfaces;
using PrayerBookDAL.Entities;

namespace PrayerBookBLL.Converters
{
    internal class ResponseConverter : IConverter<ResponseBO, Response>
    {
        public ResponseBO Convert(Response entity)
        {
            return new ResponseBO
            {
                Id = entity.Id,
                Answer = entity.Answer,
                PrayerId = entity.PrayerId,
                ResponseNumber = entity.ResponseNumber
            };
        }

        public Response Convert(ResponseBO bo)
        {
            return new Response
            {
                Id = bo.Id,
                Answer = bo.Answer,
                PrayerId = bo.PrayerId,
                ResponseNumber = bo.ResponseNumber
            };
        }
    }
}
