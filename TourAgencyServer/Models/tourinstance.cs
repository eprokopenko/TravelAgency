namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.tourinstance")]
    public partial class tourinstance
    {
        [Key]
        [Column(Order = 0)]
        public int IdTourInstance { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTour { get; set; }
    }
}
