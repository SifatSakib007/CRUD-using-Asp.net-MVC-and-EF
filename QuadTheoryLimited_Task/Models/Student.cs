using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace QuadTheoryLimited_Task.Models
{
    public class Student
    {
        
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Gender")]
        public string Gender { get; set; } = "";

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "Enter Your Date of Birth")]
        public DateTime DOB { get; set; }

        [DisplayName("Class Id")]
        // Foreign key property
        public int ClassId { get; set; }

        [ForeignKey("ClassId")] // Specify the foreign key
        public Class? Class { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DisplayName("Modification Date")]
        public DateTime ModificationDate { get; set; } = DateTime.Now;
    }
}
