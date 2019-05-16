using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Model
{
    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Grade> grades;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.grades = new HashSet<Grade>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }

        public virtual ICollection<Grade> Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }

    }
}
