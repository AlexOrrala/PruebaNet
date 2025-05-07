using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaNet.Entity
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int EstudianteId { get; set; }

        [ForeignKey("Course")]
        public int CursoId { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }

}
