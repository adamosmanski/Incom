using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.ToDoList.Model;

namespace ToDoList.Data
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task AddTaskAsync(TaskItem task);
        Task RemoveTaskAsync(int taskId);
        Task UpdateTaskStatusAsync(int taskId, Model.ToDoList.Model.TaskStatus status);
    }
}
