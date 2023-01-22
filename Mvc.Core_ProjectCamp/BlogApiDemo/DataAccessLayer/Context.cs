using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI\\DLBRMSSQLSERVER;Initial Catalog=DbMvcCoreApi_ProCamp;Integrated Security=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
