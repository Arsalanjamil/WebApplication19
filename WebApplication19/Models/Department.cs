using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication19.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [MaxLength(50)]
        public string DepartmentName { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
    }
}

