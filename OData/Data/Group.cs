using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OData.Data
{
    public partial class Group
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? Name { get; set; }
        public Guid? CountryId { get; set; }
        public int? TotalMatch { get; set; }
        public int? MatchPlayed { get; set; }
        public int? RemainingMatch { get; set; }
        public int? GoalFor { get; set; }
        public int? GoalAgainst { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? GroupId { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("Groups")]
        public virtual Country? Country { get; set; }
    }
}
