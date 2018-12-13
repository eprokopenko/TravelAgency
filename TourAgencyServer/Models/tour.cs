namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.tour")]
    public partial class tour
    {
        [Key]
        [Column(Order = 0)]
        public int IdTour { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? NightsNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHotel { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTourCategory { get; set; }

        public virtual tourcategory tourcategory { get; set; }
    }
}
