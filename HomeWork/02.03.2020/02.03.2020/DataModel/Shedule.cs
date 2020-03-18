using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Shedule
    {
        [Key]
        public int Id { get; set; }
        public int BarberId { get; set; }
        public virtual Barbers Barber { get; set; }
        public DateTime Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
