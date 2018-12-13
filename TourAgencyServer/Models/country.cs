namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.country")]
    public partial class country
    {
        [Key]
        public int IdСountry { get; set; }

        [Required]
        [StringLength(90)]
        public string Name { get; set; }
    }
}
