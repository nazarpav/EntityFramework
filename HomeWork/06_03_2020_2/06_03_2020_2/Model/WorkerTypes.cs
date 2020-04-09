using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class WorkerTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public bool? IsStaticSalary { get; set; }
        public ICollection<Workers> Workers { get; set; }
    }
}
