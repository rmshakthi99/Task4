using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProfileMVCProject.Models
{
    public class Profile
    {
        [Key]       
        public int PersonId { get; set; }
        public string Name { get;set;}
        public int age { get; set; }
        public string qualification { get; set; }
        public string IsEmployed { get; set; }
        public int NoticePeriod { get; set; }
        public float CurrentCTC { get; set; }

    }
}
