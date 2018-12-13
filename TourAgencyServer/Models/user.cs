namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("travelagency.user")]
    public partial class user
    {
        [Key]
        [Column(Order = 0)]
        public int IdUser { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(80)]
        public string Surname { get; set; }

        [StringLength(80)]
        public string Patronymic { get; set; }

        [StringLength(15)]
        public string Gender { get; set; }

        [Required]
        [StringLength(64)]
        public string Login { get; set; }

        [StringLength(128)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        public int? Series { get; set; }

        public int? No { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfIssue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ValidUntil { get; set; }

        [StringLength(250)]
        public string PlaceOfIssue { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdRole { get; set; }

        public virtual role role { get; set; }
    }
}
