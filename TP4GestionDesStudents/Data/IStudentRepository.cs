using TP4GestionDesStudents.Models;

namespace TP4GestionDesStudents.Data
{
    public interface IStudentRepository : IRepository<Student>
    {
        public IEnumerable<string> GetUniqueCourses();

        public IEnumerable<Student> StudentsByCourse(string course);
    }
}
