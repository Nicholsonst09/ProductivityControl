using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductivityControl.Models
{
    public class RestrictedApp
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ProcessName { get; set; }
        public string? Url { get; set; }
        public bool? IsBlocked { get; set; }
        public int? MaxMinsAllowed {get; set; }

        public enum RestrcitionType  //'enum' -> Special data type in C# that allows defining a set of named constants
        {
            WebSite,
            Application
        }

        public RestrcitionType? type { get; set; } 

    }
}
