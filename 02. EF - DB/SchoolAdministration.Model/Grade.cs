using System.ComponentModel.DataAnnotations;

namespace SchoolAdministration.Model
{
    public class Grade
    {
        public int Id { get; set; }

        public int Score { get; set; }

        [Required]
        public virtual Student Student { get; set; }
    }
}
