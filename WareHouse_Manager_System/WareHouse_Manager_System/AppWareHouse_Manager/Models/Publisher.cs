namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Publisher")]
    public partial class Publisher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Publisher()
        {
            Supplies = new HashSet<Supply>();
        }

        [Key]
        [StringLength(10)]
        public string Publisher_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Publisher_Name { get; set; }

        [StringLength(10)]
        public string Publisher_PhoneNumber { get; set; }

        [StringLength(200)]
        public string Publisher_Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] Publisher_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
