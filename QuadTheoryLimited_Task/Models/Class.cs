using System.ComponentModel.DataAnnotations;

namespace QuadTheoryLimited_Task.Models
{
    public class Class
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }        

        [Required(ErrorMessage = "Enter Your Name")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModificationDate { get; set; } = DateTime.Now;

        // Navigation property for students in this class
        public ICollection<Student> Students { get; set; }
    }
}
