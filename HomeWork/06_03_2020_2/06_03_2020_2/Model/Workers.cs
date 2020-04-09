using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class Workers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int ShopId { get; set; }
        [Required]
        public int WorkerTypeId { get; set; }
        public virtual Shops Shop { get; set; }
        public virtual WorkerTypes Type { get; set; }
    }
}
