namespace TourAgencyServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Newtonsoft.Json;

    [Table("travelagency.tourcategory")]
    public partial class tourcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tourcategory()
        {
            tours = new HashSet<tour>();
        }

        [Key]
        public int IdTourCategory { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

       // [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tour> tours { get; set; }
    }
}
