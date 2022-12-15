using TP4GestionDesStudents.Models;

namespace TP4GestionDesStudents.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly UniversityContext _universityContext;
        public StudentRepository(UniversityContext universityContext) : base(universityContext)
        {
            this._universityContext = universityContext;
        }
        public IEnumerable<string> GetUniqueCourses()
        {
            return _universityContext.Student.Select(x => x.course).Distinct();
        }
		public IEnumerable<Student> StudentsByCourse(string course)
		{
			return _universityContext.Student.Where(x => x.course == course);
		}
	}
}
