using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackendModules.Models
{
    public class Department
    {
        public Department()
        {
            SubDepartments = new List<Department>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }

        public int? ParentDepartmentId { get; set; }  // Nullable foreign key
        public Department ParentDepartment { get; set; }
        public ICollection<Department> SubDepartments { get; set; }
    }
}
