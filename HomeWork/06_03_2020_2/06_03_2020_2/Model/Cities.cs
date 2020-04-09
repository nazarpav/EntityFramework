using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Countries Country { get; set; }
        public ICollection<Shops> Shops { get; set; }
    }
}
