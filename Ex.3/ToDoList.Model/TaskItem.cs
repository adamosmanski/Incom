using System.ComponentModel.DataAnnotations;

namespace ToDoList.Model
{
    namespace ToDoList.Model
    {
        public class TaskItem
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public TaskStatus Status { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.Now;
        }

        public enum TaskStatus
        {
            ToDo,
            InDev,
            Done
        }
    }
}
