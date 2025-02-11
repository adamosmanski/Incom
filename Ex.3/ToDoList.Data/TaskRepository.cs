using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.ToDoList.Model;

namespace ToDoList.Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveTaskAsync(int taskId)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateTaskStatusAsync(int taskId, Model.ToDoList.Model.TaskStatus status)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task != null)
            {
                task.Status = status;
                await _context.SaveChangesAsync();
            }
        }
    }
}
