using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Patronymic { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        public ICollection<Records> Records { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }
        public ICollection<Estimations> Estimations { get; set; }
        public ICollection<VisitingArchive> visitingArchives { get; set; }

    }
}
