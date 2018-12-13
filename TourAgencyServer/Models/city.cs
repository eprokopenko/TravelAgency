namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.city")]
    public partial class city
    {
        [Key]
        [Column(Order = 0)]
        public int IdCity { get; set; }

        [Required]
        [StringLength(90)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdСountry { get; set; }
    }
}
