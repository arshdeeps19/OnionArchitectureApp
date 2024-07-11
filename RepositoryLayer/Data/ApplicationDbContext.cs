using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System.Linq;

namespace RepositoryLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository()
        {
            _context = new ApplicationDbContext();
        }

        public Students GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        // Add other CRUD methods if needed
    }
}
