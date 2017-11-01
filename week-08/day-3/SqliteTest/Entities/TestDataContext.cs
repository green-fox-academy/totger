using Microsoft.EntityFrameworkCore;
using SqliteTest.Models;

namespace SqliteTest.Entities
{
    public class TestDataContext : DbContext
    {
        public TestDataContext(DbContextOptions<TestDataContext> options) 
            : base(options)
        {
        }

        public DbSet<TestData> TestDatas { get; set; }
    }
}
