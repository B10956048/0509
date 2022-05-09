using Microsoft.EntityFrameworkCore;
namespace WebApplication1.model;
   
    public class TestDb : DbContext
    {
        public TestDb(DbContextOptions<TestDb> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }

