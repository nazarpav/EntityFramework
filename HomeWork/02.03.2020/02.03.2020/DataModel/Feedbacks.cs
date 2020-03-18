using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Feedbacks
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
        public int BarbersId { get; set; }
        public virtual Barbers Barber { get; set; }
        public ICollection<VisitingArchive> visitingArchives { get; set; }
    }
}
