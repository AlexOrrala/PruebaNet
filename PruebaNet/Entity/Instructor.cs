using System.ComponentModel.DataAnnotations;

namespace PruebaNet.Entity
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public string? Especialidad { get; set; }

        public ICollection<Course> Cursos { get; set; }
    }

}
