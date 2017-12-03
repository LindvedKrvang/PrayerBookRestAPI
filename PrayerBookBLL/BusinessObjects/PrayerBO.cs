using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrayerBookBLL.BusinessObjects
{
    public class PrayerBO
    {
        public int Id { get; set; }
        [Required]
        public string Subject { get; set; }
        public List<ResponseBO> Responses { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
