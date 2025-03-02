using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }

        public string? Address { get; set; }

        public int HourRate { get; set; }

        public ICollection<Course_Inst> InstCourses { get; set; }=new HashSet<Course_Inst>();
        [InverseProperty(nameof(Department.Manager))]
    
        public Department ManageDepartment { get; set; }
   
        public int? DepartmentId { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public Department Depart { get; set; }
    }
}
