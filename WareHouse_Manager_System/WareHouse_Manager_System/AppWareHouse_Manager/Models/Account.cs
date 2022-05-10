namespace AppWareHouse_Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(10)]
        public string Account_ID { get; set; }

        [StringLength(40)]
        public string Account_UserName { get; set; }

        [StringLength(20)]
        public string Account_Password { get; set; }

        [StringLength(100)]
        public string Account_DisplayName { get; set; }

        [StringLength(10)]
        public string Account_Category_ID { get; set; }

        [StringLength(10)]
        public string Staff_ID { get; set; }

        public virtual Account_Category Account_Category { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
