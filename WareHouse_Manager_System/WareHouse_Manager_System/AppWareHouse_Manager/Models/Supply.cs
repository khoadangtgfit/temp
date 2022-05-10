namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supply")]
    public partial class Supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supply()
        {
            Import_Detail = new HashSet<Import_Detail>();
            Output_Detail = new HashSet<Output_Detail>();
        }

        [Key]
        [StringLength(10)]
        public string Supply_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Supply_Name { get; set; }

        public int? Supply_Quantity { get; set; }

        [StringLength(50)]
        public string Supply_Unit { get; set; }

        [StringLength(10)]
        public string Supply_Category_ID { get; set; }

        [StringLength(10)]
        public string Publisher_ID { get; set; }

        [Column(TypeName = "image")]
        public byte[] Supply_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import_Detail> Import_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Output_Detail> Output_Detail { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Supply_Category Supply_Category { get; set; }
    }
}
