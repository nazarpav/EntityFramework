using MFluentApi.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace DALnamespace
{
    public class ShopNetwork : DbContext
    {
        public ShopNetwork()
            : base("name=ShopNetwork")
        {
            Database.SetInitializer<ShopNetwork>(new Model1Initializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cities>().HasRequired(b => b.Country).WithMany(a => a.Cities).HasForeignKey(v => v.CountryId).WillCascadeOnDelete(true);

            modelBuilder.Entity<Shops>().HasRequired(b => b.City).WithMany(a => a.Shops).HasForeignKey(v => v.CityId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Shops>().HasMany(b => b.Products).WithMany(a => a.Shops);
            modelBuilder.Entity<Shops>().HasKey(y => y.DirectorId);

            modelBuilder.Entity<Directors>().HasOptional(k => k.Shop).WithRequired(l => l.Director);


            modelBuilder.Entity<Workers>().HasRequired(b => b.Type).WithMany(a => a.Workers).HasForeignKey(v => v.WorkerTypeId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Workers>().HasRequired(b => b.Shop).WithMany(a => a.Workers).HasForeignKey(v => v.ShopId).WillCascadeOnDelete(true);
        }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<Shops> Shops { get; set; }
        public virtual DbSet<WorkerTypes> WorkerTypes { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Directors> Directors { get; set; }
        public virtual DbSet<Categiries> Categiries { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
    }
}
