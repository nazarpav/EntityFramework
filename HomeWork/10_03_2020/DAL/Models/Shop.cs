using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int? ParkingArea { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
