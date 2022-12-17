using tp4dotnet.Models;

namespace tp4dotnet.Data
{
    public interface IRepositoryStudent : IRepository<Student>
    {
        public IEnumerable<string?> GetCourses();
    }
}