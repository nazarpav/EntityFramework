using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Services
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Duration { get; set; }
        public ICollection<BarbersServices> BarbersServices { get; set; }
        public ICollection<VisitingArchive> visitingArchives { get; set; }

    }
}
