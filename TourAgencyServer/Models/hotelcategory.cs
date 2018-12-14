namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Newtonsoft.Json;

    [Table("travelagency.hotelcategory")]
    public partial class hotelcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotelcategory()
        {
            hotels = new HashSet<hotel>();
        }

        [Key]
        public int IdHotelCategory { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hotel> hotels { get; set; }
    }
}
