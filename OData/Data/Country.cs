using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OData.Data
{
    public partial class Country
    {
        public Country()
        {
            Groups = new HashSet<Group>();
        }

        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Region { get; set; }
        public string? TeamCaptain { get; set; }
        public string? TeamCoach { get; set; }

        [InverseProperty("Country")]
        public virtual ICollection<Group> Groups { get; set; }
    }
}
