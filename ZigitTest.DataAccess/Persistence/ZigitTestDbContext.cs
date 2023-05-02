using Microsoft.EntityFrameworkCore;
using ZigitTest.Domain.Models;

namespace ZigitTest.DataAccess.Persistence
{
    public class ZigitTestDbContext:DbContext
    {
        public ZigitTestDbContext(DbContextOptions<ZigitTestDbContext> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }


    }
}
