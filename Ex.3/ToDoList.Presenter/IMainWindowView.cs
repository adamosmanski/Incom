using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.ToDoList.Model;
using TaskStatus = ToDoList.Model.ToDoList.Model.TaskStatus;

namespace ToDoList.Presenter
{
    public interface IMainWindowView
    {
        event EventHandler OnTaskAdded;
        event EventHandler OnTaskRemoved;
        event EventHandler OnTaskUpdated;

        string NewTaskDescription { get; set; }
        int? SelectedTaskId { get; set; }
        TaskStatus SelectedTaskStatus { get;set; }

        void ShowTasks(List<TaskItem> tasks);
    }
}
