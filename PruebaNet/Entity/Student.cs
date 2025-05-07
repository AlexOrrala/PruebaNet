using System.ComponentModel.DataAnnotations;

namespace PruebaNet.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }

}
