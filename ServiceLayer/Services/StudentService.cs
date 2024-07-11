using DomainLayer.Entities;
using DomainLayer.Interfaces;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Students GetStudent(int id)
        {
            return _studentRepository.GetStudent(id);
        }

        public void AddStudent(Students student) 
        {
            _studentRepository.AddStudent(student); 
        }
    }
}
