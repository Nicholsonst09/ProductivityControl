using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityControl.Models
{
    public class UsageLog
    {
        [Key]
        public int Id { get; set; }
        public int RestrictedAppId { get; set; }
        public DateTime Startime { get; set; }
        public DateTime? Endtime { get; set; }  // '?' indicates that it may be null
        public int TimeUsing {  get; set; }


    }
}
