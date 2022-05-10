namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Import_Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Import_Coupon()
        {
            Import_Detail = new HashSet<Import_Detail>();
        }

        [Key]
        [StringLength(10)]
        public string Import_Coupon_ID { get; set; }

        public DateTime? Import_Coupon_Date { get; set; }

        [StringLength(10)]
        public string Staff_ID { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_Detail> Import_Detail { get; set; }
    }
}
