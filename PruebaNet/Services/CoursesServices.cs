using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNet.Entity;

namespace PruebaNet.Services
{
    public class CoursesServices
    {
        private readonly AppDbContext _context;

        public CoursesServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetCourses()
        {
            List<Course> cursos = await _context.Courses
                .Include(c => c.Instructor)
                .Include(c => c.Enrollments)
                    .ThenInclude(e => e.Student)
                .ToListAsync();

            return cursos;
        }
    }
}
