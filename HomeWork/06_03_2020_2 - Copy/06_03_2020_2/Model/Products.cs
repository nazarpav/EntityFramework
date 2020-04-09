using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int Price { get; set; }
        public int? Discount { get; set; }
        [Required]
        public bool IsInStook { get; set; }
        public ICollection<Shops> Shops { get; set; }
    }
}
