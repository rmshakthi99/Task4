using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPIProject.Models
{
    public class weather
    {
        [Key]
        public string City { get; set; }
        public DateTime Date { get; set; }
        public string LowTemp { get; set; }
        public string HighTemp { get; set; }
 public string ForeCast { get; set; }
    
    }
}
