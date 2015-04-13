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
    public class Belief
    {
        public int BeliefID { get; set; }

        [Required]
        public string BeliefTitle { get; set; }

        public string BeliefDetails { get; set; }

    }
}
