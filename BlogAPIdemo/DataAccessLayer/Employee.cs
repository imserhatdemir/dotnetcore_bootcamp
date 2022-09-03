using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIdemo.DataAccessLayer
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
