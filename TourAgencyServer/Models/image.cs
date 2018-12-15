namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.image")]
    public partial class image
    {
        [Key]
        public int IdImage { get; set; }

        [Required]
        [StringLength(1024)]
        public string Path { get; set; }

        [StringLength(45)]
        public string Imagecol { get; set; }

        public int? IdCity { get; set; }

        public int? IdTourCategory { get; set; }

        public int? IdTour { get; set; }
    }
}
