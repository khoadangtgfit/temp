namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Output_Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Output_Coupon()
        {
            Output_Detail = new HashSet<Output_Detail>();
        }

        [Key]
        [StringLength(10)]
        public string Output_Coupon_ID { get; set; }

        public DateTime? Output_Coupon_Date { get; set; }

        [StringLength(100)]
        public string Output_Coupon_Address { get; set; }

        [StringLength(10)]
        public string Staff_ID { get; set; }

        public virtual Staff Staff { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Output_Detail> Output_Detail { get; set; }
    }
}
