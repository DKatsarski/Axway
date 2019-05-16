using SchoolAdministration.Data;
using SchoolAdministration.Model;
using System;
using System.Linq;

namespace SchoolAdministration
{
    class Startup
    {
        static void Main()
        {
            var db = new SchoolAdministrationDbContext();

            var student = new Student()
            {
                Name = "Gosho"
            };

            db.Students.Add(student);
            db.SaveChanges();

            Console.WriteLine(db.Students.Count());
        }
    }
}
