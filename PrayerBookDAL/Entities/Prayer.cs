using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookDAL.Entities
{
    public class Prayer
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int ResponseNumber { get; set; }
        public string UserId { get; set; }
    }
}
