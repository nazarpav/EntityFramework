using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03._2020.DataModel
{
    public class Records
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
        public int BarbersID { get; set; }
        public virtual Barbers Barber { get; set; }
        public DateTime Date_Time { get; set; }
    }
}
