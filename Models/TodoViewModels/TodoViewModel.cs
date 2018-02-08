using System.Collections.Generic;

namespace AspNetCoreTodo.Models.TodoViewModels
{
    public class TodoViewModel
    {
        public IEnumerable<TodoItem> Items { get; set; }
    }
}