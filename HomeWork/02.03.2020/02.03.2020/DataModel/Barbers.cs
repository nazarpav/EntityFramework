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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
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
