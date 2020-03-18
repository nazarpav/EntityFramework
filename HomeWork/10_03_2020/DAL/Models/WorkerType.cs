using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class WorkerType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isStaticSalary { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
