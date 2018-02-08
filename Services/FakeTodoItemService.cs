using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models.TodoViewModels;

namespace AspNetCoreTodo.Services
{
  public class FakeTodoItemService : ITodoItemService
  {
    public Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync()
    {
        // Return an array of todoitems
        IEnumerable<TodoItem> items = new[]
        {
            new TodoItem
            {
                Title = "Learn Asp.net Core 2",
                DueAt = DateTimeOffset.Now.AddDays(2)
            },
            new TodoItem
            {
                Title = "Build something awesome",
                DueAt = DateTimeOffset.Now.AddDays(1)
            }
        };
        return Task.FromResult(items);
    }
  }
}