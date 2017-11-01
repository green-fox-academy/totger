using System;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Entities
{
    public class TodoContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=blogging.db");
        //}
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }


        public DbSet<Todo> Todos { get; set; }
    }
}
