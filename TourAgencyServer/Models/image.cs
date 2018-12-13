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
        [Column(Order = 0)]
        public int IdImage { get; set; }

        [Required]
        [StringLength(1024)]
        public string Path { get; set; }

        [StringLength(45)]
        public string Imagecol { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCity { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTourCategory { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTour { get; set; }

        public virtual tourcategory tourcategory { get; set; }
    }
}
