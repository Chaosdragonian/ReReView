namespace ReReView.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ReReViewContext : DbContext
    {
        public ReReViewContext()
            : base("ReReViewContext")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Restuarant> Restuarants { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>()
                .Property(e => e.menuName)
                .IsUnicode(false);

            modelBuilder.Entity<Menu>()
                .Property(e => e.menuType)
                .IsUnicode(false);

            modelBuilder.Entity<Restuarant>()
                .Property(e => e.restaurantName)
                .IsUnicode(false);

            modelBuilder.Entity<Restuarant>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<Restuarant>()
                .Property(e => e.openTime)
                .IsUnicode(false);

            modelBuilder.Entity<Restuarant>()
                .Property(e => e.closeTIme)
                .IsUnicode(false);

            modelBuilder.Entity<Restuarant>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.Restuarant)
                .HasForeignKey(e => e.menuRestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restuarant>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Restuarant)
                .HasForeignKey(e => e.reviewRestaurantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.reviewExplanation)
                .IsUnicode(false);

        }
    }
}
