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
    public class Photo
    {
        public int PhotoID { get; set; }

        [Required]
        public string PhotoTitle { get; set; }

        [Required]
        public string PhotoDescription { get; set; }

        public DateTime PhotoDate { get; set; }
    }
}
