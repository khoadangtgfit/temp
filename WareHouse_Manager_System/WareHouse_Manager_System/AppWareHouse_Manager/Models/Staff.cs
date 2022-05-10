namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Accounts = new HashSet<Account>();
            Import_Coupon = new HashSet<Import_Coupon>();
            Output_Coupon = new HashSet<Output_Coupon>();
        }

        [Key]
        [StringLength(10)]
        public string Staff_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Staff_Name { get; set; }

        [StringLength(200)]
        public string Staff_Address { get; set; }

        [StringLength(10)]
        public string Staff_PhoneNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? Staff_Salary { get; set; }

        [StringLength(10)]
        public string Staff_Category_ID { get; set; }

        [Column(TypeName = "image")]
        public byte[] Staff_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_Coupon> Import_Coupon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Output_Coupon> Output_Coupon { get; set; }

        public virtual Staff_Category Staff_Category { get; set; }
    }
}
