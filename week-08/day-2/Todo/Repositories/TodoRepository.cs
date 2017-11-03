using System;
using System.Collections.Generic;
using System.Linq;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public IOrderedEnumerable<Todo> ListTodos()
        {
            var currentList = todoContext.Current.ToList();
            currentList.ForEach(t => t.UpdateDaysRemaining());
            return currentList.OrderBy(t => t.DaysRemaining);
        }

        public void AddTodo(string newTitle, int isImportant, DateTime dueDate)
        {

            var newTodo = new Todo
            {
                Title = newTitle,
                IsImportant = (isImportant == 1),
                DueDate = dueDate
            };

            todoContext.Current.Add(newTodo);
            todoContext.SaveChanges();
        }

        internal void DeleteTodo(int id)
        {
            Todo archiveTodo = todoContext.Current.FirstOrDefault(x => x.Id == id);
            todoContext.Current.Remove(archiveTodo);
            todoContext.SaveChanges();
        }

        internal void Done(int id)
        {
            Todo doneTodo = todoContext.Current.FirstOrDefault(x => x.Id == id);
            doneTodo.IsDone = !doneTodo.IsDone;
            todoContext.SaveChanges();
        }
    }
}
