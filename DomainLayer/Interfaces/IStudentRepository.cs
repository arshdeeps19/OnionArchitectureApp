using DomainLayer.Entities;

namespace DomainLayer.Interfaces
{
    public interface IStudentRepository
    {
        Students GetStudent(int id);
        void AddStudent(Students student); // Add this method
    }
}
