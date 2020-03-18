namespace DAL
{
    using DalNameSpace;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DAL.Configs;
    public class FluentApiAndEtc : DbContext
    {
        public FluentApiAndEtc()
            : base("name=FluentApiAndEtc")
        {
            Database.SetInitializer<FluentApiAndEtc>(new Initializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CityConfig());
            modelBuilder.Configurations.Add(new DirectorConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new ShopConfig());
            modelBuilder.Configurations.Add(new WorkerConfig());
        }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<WorkerType> WorkerTypes { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}
