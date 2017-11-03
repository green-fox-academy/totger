using System;
using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Todo> Current { get; set; }
    }
}
