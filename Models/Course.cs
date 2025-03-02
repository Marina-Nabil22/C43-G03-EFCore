using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment
{
    public class Course
    {
        public int Id { get; set; }

        public int Duration { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Stud_Course> CourseStudents { get; set; }=new HashSet<Stud_Course>();

        [ForeignKey(nameof(Topic))]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
   
    public ICollection<Course_Inst> course_Insts { get; set; } =new HashSet<Course_Inst>();
    
    }
}
