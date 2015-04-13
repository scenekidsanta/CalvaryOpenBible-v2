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
    public class Contact
    {
        public int ContactID { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        // set formatting requirement to be in telephone style
        public string Telphone { get; set; }

        [Required]
        // set formatting requirement to be in email style
        public string Email { get; set; }
    }
}