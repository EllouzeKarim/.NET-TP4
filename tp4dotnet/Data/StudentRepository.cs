using tp4dotnet.Models;

namespace tp4dotnet.Data
{
    public class StudentRepository : Repository<Student>, IRepositoryStudent
    {
        private readonly UniversityContext universityContext;
        public StudentRepository()
        {
            this.universityContext = UniversityContext.Instantiate_UniversityContext(); ;
        }

        public IEnumerable<string?> GetCourses()
        {
            return universityContext.Student.Select(s => s.course).Distinct().ToList();
        }
    }
}
