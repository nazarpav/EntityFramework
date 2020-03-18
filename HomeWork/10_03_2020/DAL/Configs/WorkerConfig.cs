using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace.Configs
{
    class WorkerConfig : EntityTypeConfiguration<Worker>
    {
        public WorkerConfig()
        {
           this.HasKey(c => c.Id);
           this.HasRequired(c => c.WorkerType).WithMany(b => b.Workers).HasForeignKey(c => c.WorkerTypeId);
            this.HasRequired(c => c.Shop).WithMany(d => d.Workers).HasForeignKey(f => f.ShopId);
        }
    }
}
