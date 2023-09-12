using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class ToDoService
    {
        private readonly ToDoContext context;

        public ToDoService(ToDoContext context)
        {
            this.context = context;
        }

        //sync
        //async
        public async Task<List<ToDo>>GetToDosAsync()
        { 
            return await context.ToDos.ToListAsync(); 
        }

        internal async Task AddAsync(ToDo toDo)
        {
            await context.ToDos.AddAsync(toDo);
            await context.SaveChangesAsync();
        }
    }
}
