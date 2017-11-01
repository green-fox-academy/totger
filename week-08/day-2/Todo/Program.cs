using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            //using (var db = new TodoContext())
            //{
            //    db.Todos.Add(new Todo { Title = "gssfgsfdg" });
            //    var count = db.SaveChanges();
            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine();
            //    Console.WriteLine("All blogs in database:");
            //    foreach (var todo in db.Todos)
            //    {
            //        Console.WriteLine(" - {0}", todo.Title);
            //    }
            //}
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
