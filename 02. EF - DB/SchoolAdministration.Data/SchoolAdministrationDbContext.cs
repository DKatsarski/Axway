using SchoolAdministration.Model;
using System.Data.Entity;

namespace SchoolAdministration.Data
{
    public class SchoolAdministrationDbContext : DbContext
    {
        public SchoolAdministrationDbContext()
            : base("SchoolDbTesting")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Grade> Grades { get; set; }
    }
}
