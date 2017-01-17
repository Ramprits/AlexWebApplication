using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.EmployeeViewModels
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string Title { get; set; }

        [Display(Name = "Name"), Required(ErrorMessage = "Must enter Name")]
        public string Name { get; set; }

        [Display(Name = "Salary"), Required(ErrorMessage = "Must enter Salary")]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Must enter Location")]
        public string Location { get; set; }

        public virtual Department Departments { get; set; }
    }
}