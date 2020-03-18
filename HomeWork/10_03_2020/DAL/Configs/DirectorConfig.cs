using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace.Configs
{
    class DirectorConfig :EntityTypeConfiguration<Director>
    {
        public DirectorConfig()
        {
            this.HasKey(c => c.Id);
            this.Ignore(a => a.FullName);
            this.Property(c => c.Phone).IsRequired();
            this.Property(c => c.Education).IsOptional();

        }
    }
}
