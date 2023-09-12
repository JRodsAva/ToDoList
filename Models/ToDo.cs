using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        public  int Id { get; set; }
        [Required]
        public string Task { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public Status Status { get; set; } = Status.Created;
    }
}
