using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalvaryOpebBibleWebsite.Models
{
    public class Calendar
    {
        public int CalendarID { get; set; }

        [Required]
        public string Month { get; set; }

        [Required]
        public int Day { get; set; }

        [Required]
        public int Year { get; set; }
    }
}

