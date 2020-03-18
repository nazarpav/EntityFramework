using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class EstimationsTypes
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Estimations> Estimations { get; set; }
    }
}
