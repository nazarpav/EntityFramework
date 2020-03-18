﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalNameSpace
{
    public class Director
    {
        [ForeignKey("Shop")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Education { get; set; }

        public virtual Shop Shop { get; set; }

        public string FullName { get { return Name + " " + Surname; } }
    }
}