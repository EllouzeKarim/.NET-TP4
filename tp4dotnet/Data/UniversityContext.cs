using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using tp4dotnet.Models;

namespace tp4dotnet.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        private UniversityContext(DbContextOptions o) : base(o)
        {
        }

        private static UniversityContext Context;
        public static UniversityContext Instantiate_UniversityContext()
        {

            if (Context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\ad\\Desktop\\GL3\\Framework\\2022 GL3 .NET Framework TP4 - SQLite database.db");
                Debug.WriteLine("Une nouvelle instance créee!");
                Context = new UniversityContext(optionsBuilder.Options);
            }
            List<Student> s = Context.Student.ToList();
            foreach (Student a in s)
            {
                Debug.WriteLine(a.id);
            }
            return Context;

        }


    }
}
