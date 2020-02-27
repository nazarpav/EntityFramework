using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst
{
    class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            HasRequired(b => b.Countries).WithMany(a => a.City).HasForeignKey(b => b.CountryId);
        }
    }
    class DirectorConfig : EntityTypeConfiguration<Director>
    {
        public DirectorConfig()
        {
            HasRequired(b => b.Shop).WithRequiredPrincipal(q=>q.Director);
        }
    }
    class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasRequired(b => b.Category).WithMany(a => a.Products).HasForeignKey(b => b.CategoryId);

        }
    }
    class ShopConfig : EntityTypeConfiguration<Shop>
    {
        public ShopConfig()
        {
            HasRequired(b => b.City).WithMany(a => a.Shop).HasForeignKey(b => b.CityId);
            HasRequired(b => b.Director).WithRequiredPrincipal(q => q.Shop);
            HasMany(b => b.Workers).WithRequired( a => a.Shop).HasForeignKey(b => b.ShopId);

        }
    }
    class WorkerConfig : EntityTypeConfiguration<Worker>
    {
        public WorkerConfig()
        {
            HasRequired(b => b.Shop).WithMany(a => a.Workers).HasForeignKey(b => b.ShopId);
            HasRequired(b => b.WorkerType).WithMany(a => a.Worker).HasForeignKey(b => b.ShopId);
        }
    }

}
