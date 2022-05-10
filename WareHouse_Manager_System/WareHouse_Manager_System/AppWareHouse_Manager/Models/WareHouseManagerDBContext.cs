using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppWareHouse_Manager.Models
{
    public partial class WareHouseManagerDBContext : DbContext
    {
        public WareHouseManagerDBContext()
            : base("name=WareHouseManagerDBContext2")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Account_Category> Account_Category { get; set; }
        public virtual DbSet<Import_Coupon> Import_Coupon { get; set; }
        public virtual DbSet<Import_Detail> Import_Detail { get; set; }
        public virtual DbSet<Output_Coupon> Output_Coupon { get; set; }
        public virtual DbSet<Output_Detail> Output_Detail { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_Category> Staff_Category { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<Supply_Category> Supply_Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Account_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Account_UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Account_Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Account_Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Staff_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Account_Category>()
                .Property(e => e.Account_Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import_Coupon>()
                .Property(e => e.Import_Coupon_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import_Coupon>()
                .Property(e => e.Staff_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import_Coupon>()
                .HasMany(e => e.Import_Detail)
                .WithRequired(e => e.Import_Coupon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Import_Detail>()
                .Property(e => e.Import_Coupon_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import_Detail>()
                .Property(e => e.Supply_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import_Detail>()
                .Property(e => e.Import_Detail_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Output_Coupon>()
                .Property(e => e.Output_Coupon_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Output_Coupon>()
                .Property(e => e.Staff_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Output_Coupon>()
                .HasMany(e => e.Output_Detail)
                .WithRequired(e => e.Output_Coupon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Output_Detail>()
                .Property(e => e.Output_Coupon_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Output_Detail>()
                .Property(e => e.Supply_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Output_Detail>()
                .Property(e => e.Output_Detail_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Publisher_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Publisher_PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Staff_Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Staff_Category>()
                .Property(e => e.Staff_Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Supply>()
                .Property(e => e.Supply_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Supply>()
                .Property(e => e.Supply_Category_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Supply>()
                .Property(e => e.Publisher_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Supply>()
                .HasMany(e => e.Import_Detail)
                .WithRequired(e => e.Supply)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supply>()
                .HasMany(e => e.Output_Detail)
                .WithRequired(e => e.Supply)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supply_Category>()
                .Property(e => e.Supply_Category_ID)
                .IsUnicode(false);
        }
    }
}
