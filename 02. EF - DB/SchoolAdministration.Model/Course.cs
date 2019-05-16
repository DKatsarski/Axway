using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Model
{
    public class Course
    {
        private ICollection<Student> students;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Title { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
