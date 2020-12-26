using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCRUDProject.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        public Department Department { get; set; }
        
        [Display(Name = "Emp Code")]
        public string Code { get; set; }
        [Display(Name = "Date Of Joining")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? DOJ { get; set; }
        [Display(Name = "Dept Name")]
        public int DepartmentId { get; set; }
    }
}