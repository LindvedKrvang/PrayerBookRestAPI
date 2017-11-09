using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDAL.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public int PrayerId { get; set; }
        public int ResponseNumber { get; set; }
    }
}
