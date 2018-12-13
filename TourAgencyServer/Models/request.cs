namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.request")]
    public partial class request
    {
        [Key]
        [Column(Order = 0)]
        public int IdRequest { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(256)]
        public string Direction { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public int? Quantity { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdStatus { get; set; }

        public virtual status status { get; set; }
    }
}
