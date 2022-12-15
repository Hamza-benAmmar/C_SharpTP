using Microsoft.EntityFrameworkCore;
using TP4GestionDesStudents.Models;

namespace TP4GestionDesStudents.Data
{
    public class UniversityContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        private static UniversityContext? _instance;
        public static UniversityContext Instance
        {
            get
            {
                if (_instance is null)
                {
                    Console.WriteLine("First time");
                    _instance = Instantiate_UniversityContext();
                }
                Console.WriteLine("Instance of UniversityContext already exists");
                return _instance;
            }
        }
        private UniversityContext(DbContextOptions o) : base(o) { }

        private static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            optionsBuilder.UseSqlite("Data Source=.\\2022 GL3 .NET Framework TP4 - SQLite database.db;");

            return new UniversityContext(optionsBuilder.Options);

        }

    }
}
