using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal? Discount { get; set; }
        public bool IsOnStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
