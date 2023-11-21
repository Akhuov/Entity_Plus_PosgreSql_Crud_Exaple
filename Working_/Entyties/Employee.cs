using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_.Entyties
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public int StaffId { get; set; }

        public Staff staff { get; set; }
    }
}
