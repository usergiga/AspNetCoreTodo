using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models.TodoViewModels;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
         Task<IEnumerable<TodoItem>> GetIncompleteItemsAsync();
    }
}