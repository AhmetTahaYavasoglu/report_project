using Microsoft.EntityFrameworkCore;

namespace report_project.Models
{
    public class Context:DbContext
    {
        public Context()
        {


        }
        public Context(DbContextOptions<Context> options)
      : base(options)
        { }
        public DbSet<report> reports { get; set; }

    }
}
