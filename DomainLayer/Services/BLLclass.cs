using DomainLayer.Entities;
using DomainLayer.Interfaces;

namespace DomainLayer.Services
{
    public class BLLclass : IStudentService
    {
        public Students GetStudent(int id)
        {
            // Business logic here
            return new Students { Studentid = id, FirstName = "John", LastName = "Doe", Age = 20 };
        }
    }
}
