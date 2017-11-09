using System;
using System.Collections.Generic;
using System.Text;

namespace PrayerBookBLL.BusinessObjects
{
    public class ResponseBO
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public int PrayerId { get; set; }
        public int ResponseNumber { get; set; }

    }
}
