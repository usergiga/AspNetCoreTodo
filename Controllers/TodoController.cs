using System.Threading.Tasks;
using AspNetCoreTodo.Models.TodoViewModels;
using AspNetCoreTodo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            // Get todo items from database
            var todoItems = await _todoItemService.GetIncompleteItemsAsync();

            // Populate the model
            var model = new TodoViewModel()
            {
                Items = todoItems
            };

            // Render view using model
            return View(model);
        }   
    }
}