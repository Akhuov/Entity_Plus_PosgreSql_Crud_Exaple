using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_.Entyties
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

      public  ICollection<Employee> Employees { get; set; }
    }
}
