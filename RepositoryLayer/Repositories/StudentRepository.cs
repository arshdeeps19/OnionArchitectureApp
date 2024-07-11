using DomainLayer.Entities;
using DomainLayer.Interfaces;
using System.Data.Entity;

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

        public void AddStudent(Students student) // Implement this method
        {
            _context.Students.Add(student);
            _context.SaveChanges(); // Save changes to the database
        }
    }
}
