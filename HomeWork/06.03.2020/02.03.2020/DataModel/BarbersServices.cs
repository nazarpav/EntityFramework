using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class BarbersServices
    {
        [Key]
        public int Id { get; set; }
        public int ServicesId { get; set; }
        public virtual Services Setvice { get; set; }
        public int BarberId { get; set; }
        public virtual Barbers Barber { get; set; }

    }
}
