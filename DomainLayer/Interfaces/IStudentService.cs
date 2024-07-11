using DomainLayer.Entities;

namespace DomainLayer.Interfaces
{
    public interface IStudentService
    {
        Students GetStudent(int id);
        void AddStudent(Students student); // Add this method
    }
}
