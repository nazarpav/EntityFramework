using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class Shops
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        public bool? ParkingArea { get; set; }
        [Required]
        public int CityId { get; set; }
        public int DirectorId { get; set; }
        public virtual Directors Director { get; set; }
        public virtual Cities City { get; set; }
        public ICollection<Workers> Workers { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
