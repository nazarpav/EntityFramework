using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace.Configs
{
    class ProductConfig : EntityTypeConfiguration<Product>
    {
       public ProductConfig()
        {
       this.HasKey(c => c.Id);
       this.HasRequired(c => c.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId);
        }
    }
}
