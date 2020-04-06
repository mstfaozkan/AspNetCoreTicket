using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Demand
    {
        [Key]
        public int Id { get; set; }
        public int FromWhoId { get; set; }
        public int ToWhoId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }

        [ForeignKey("FromWhoId")]
        public virtual Client FromWhoClient { get; set; }


        [ForeignKey("ToWhoId")]
        public virtual Client ToWhoClient { get; set; }
    }
}
