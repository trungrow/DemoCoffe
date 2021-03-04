namespace DemoCoffe.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbCoffe : DbContext
    {
        public DbCoffe()
            : base("name=DbCoffe")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CoffeTable> CoffeTables { get; set; }
        public virtual DbSet<CoffeTableState> CoffeTableStates { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminUserName)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminMail)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.AdminAvatar)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffCode)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffMail)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CoffeTableState>()
                .Property(e => e.StateColor)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderCode)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderCodeDiscount)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotalDiscount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotalTax)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductDiscount)
                .HasPrecision(18, 0);
        }
    }
}
