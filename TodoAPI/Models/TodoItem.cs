using Microsoft.EntityFrameworkCore;   
namespace TodoApi.Models        // A model is an object that represents a to-do item.
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}      