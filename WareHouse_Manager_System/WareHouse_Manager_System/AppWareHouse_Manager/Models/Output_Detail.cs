namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Output_Detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Output_Coupon_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Supply_ID { get; set; }

        public int? Output_Detail_Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Output_Detail_Price { get; set; }

        [StringLength(100)]
        public string Output_Detail_Note { get; set; }

        public virtual Output_Coupon Output_Coupon { get; set; }

        public virtual Supply Supply { get; set; }
    }
}
