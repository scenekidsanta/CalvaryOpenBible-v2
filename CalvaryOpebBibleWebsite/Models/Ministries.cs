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
    public class Ministries
    {
        [Key]
        public int MinitriesID { get; set; }

        [Required]
        public string MinistriesLeader { get; set; }

        public string MinistriesPosition { get; set; }
    }
}