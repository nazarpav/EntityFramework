using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        public int WorkerTypeId { get; set; }
        public virtual WorkerType WorkerType { get; set; }

    }
}
