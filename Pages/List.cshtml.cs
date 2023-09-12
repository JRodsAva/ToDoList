using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Pages
{
    public class ListModel : PageModel
    {
        private readonly ToDoService toDoService;
        public List<ToDo> ToDos { get; set; }
        public ListModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        public async Task OnGet()
        {
            ToDos = await toDoService.GetToDosAsync();
            return;
        }
    }
}
