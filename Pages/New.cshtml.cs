using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Pages
{
    public class NewModel : PageModel
    {
        private readonly ToDoService toDoService;
        [BindProperty]
        public ToDo ToDo { get; set; }
        public NewModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;   
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid) 
            {
                return Page();
            }
            else
            {
                await toDoService.AddAsync(ToDo);
                return LocalRedirect("/list");
            }
        }
    }
}
