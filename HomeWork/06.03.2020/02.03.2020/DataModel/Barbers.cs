using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    [Table("Barbers")]
    public class Barbers
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
        public string Sex { get; set; }
        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(40)]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime EmploymentDate { get; set; }
        public int PositionId { get; set; }
        public virtual Positions Position { get; set; }
        public ICollection<Shedule> Shedules { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }
        public ICollection<Records> Records { get; set; }
        public ICollection<Estimations> Estimations { get; set; }
        public ICollection<BarbersServices> BarbersServices { get; set; }
        public ICollection<VisitingArchive> visitingArchives { get; set; }
    }
}
