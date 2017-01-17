using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.EmployeeViewModels
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; private set; }

        [Display(Name = "Department Name"), Required(ErrorMessage = "Please Enter Department Name")]
        public string DepartmentName { get; private set; }

        public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;

        [ForeignKey("Employee" + "Id")]
        public int EmployeeId { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}