using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Estimations
    {
        [Key]
        public int Id { get; set; }
        public int BarberId { get; set; }
        public virtual Barbers Barber { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
        public int EstimationsTypeId { get; set; }
        public virtual EstimationsTypes EstimationsType { get; set; }
        public ICollection<VisitingArchive> visitingArchives { get; set; }
    }
}
