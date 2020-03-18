using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace.Configs
{
    class ShopConfig : EntityTypeConfiguration<Shop>
    {
        public ShopConfig()
        {
           this.HasKey(c => c.Id);
            this.HasRequired(c => c.City).WithMany(d => d.Shops).HasForeignKey(c => c.CityId).WillCascadeOnDelete(true);
            this.HasMany(c => c.Products).WithMany(c => c.Shops);
            this.HasOptional(c => c.Director).WithRequired(b => b.Shop);
        }
    }
}
