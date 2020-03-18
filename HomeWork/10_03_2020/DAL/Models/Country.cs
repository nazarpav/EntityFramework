using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
