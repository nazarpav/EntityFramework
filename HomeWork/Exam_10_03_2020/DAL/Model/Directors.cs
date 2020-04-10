using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFluentApi.Model
{
    public class Directors
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public bool? Education { get; set; }
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        public Shops Shop { get; set; }
        [NotMapped] 
        public string FullName { get { return FirstName + " " + LastName; } }

    }
}
