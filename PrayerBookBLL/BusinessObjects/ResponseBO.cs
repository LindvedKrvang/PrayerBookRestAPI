using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrayerBookBLL.BusinessObjects
{
    public class ResponseBO
    {
        public int Id { get; set; }
        [Required]
        public string Answer { get; set; }
        [Required]
        public int PrayerId { get; set; }
        [Required]
        public string UserId { get; set; }
        public int ResponseNumber { get; set; }

    }
}
