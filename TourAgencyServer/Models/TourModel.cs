namespace TourAgencyServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TourModel : DbContext
    {
        public TourModel()
            : base("name=TourModel")
        {
        }

        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<hotel> hotels { get; set; }
        public virtual DbSet<hotelcategory> hotelcategories { get; set; }
        public virtual DbSet<image> images { get; set; }
        public virtual DbSet<nutrition> nutritions { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<tour> tours { get; set; }
        public virtual DbSet<tourcategory> tourcategories { get; set; }
        public virtual DbSet<tourinstance> tourinstances { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<hotel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<hotel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<hotel>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<hotelcategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<hotelcategory>()
                .HasMany(e => e.hotels)
                .WithRequired(e => e.hotelcategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<image>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<image>()
                .Property(e => e.Imagecol)
                .IsUnicode(false);

            modelBuilder.Entity<nutrition>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<nutrition>()
                .HasMany(e => e.hotels)
                .WithRequired(e => e.nutrition)
                .HasForeignKey(e => e.IdNutritionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<request>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<request>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<request>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<request>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<status>()
                .HasMany(e => e.requests)
                .WithRequired(e => e.status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tour>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tour>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tourcategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tourcategory>()
                .HasMany(e => e.images)
                .WithRequired(e => e.tourcategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tourcategory>()
                .HasMany(e => e.tours)
                .WithRequired(e => e.tourcategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.PlaceOfIssue)
                .IsUnicode(false);
        }
    }
}
