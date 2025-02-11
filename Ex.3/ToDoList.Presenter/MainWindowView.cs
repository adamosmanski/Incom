using ToDoList.Data;
using ToDoList.Model.ToDoList.Model;
using TaskStatus = ToDoList.Model.ToDoList.Model.TaskStatus;

namespace ToDoList.Presenter
{
    public class MainWindowPresenter
    {
        private readonly IMainWindowView _view;
        private readonly ITaskRepository _repository;

        public MainWindowPresenter(IMainWindowView view)
        {
            _view = view;
            _repository = new TaskRepository();

            _view.OnTaskAdded += async (s, e) => await AddTask();
            _view.OnTaskRemoved += async (s, e) => await RemoveTask();
            _view.OnTaskUpdated += async (s, e) => await UpdateTaskStatus();
        }

        public async Task LoadTasks()
        {
            var tasks = await _repository.GetAllTasksAsync();
            _view.ShowTasks(tasks);
        }

        private async Task AddTask()
        {
            if (!string.IsNullOrWhiteSpace(_view.NewTaskDescription))
            {
                var task = new TaskItem
                {
                    Description = _view.NewTaskDescription,
                    Status = TaskStatus.ToDo
                };
                await _repository.AddTaskAsync(task);
                await LoadTasks();
            }
        }

        private async Task RemoveTask()
        {
            if (_view.SelectedTaskId.HasValue)
            {
                await _repository.RemoveTaskAsync(_view.SelectedTaskId.Value);
                await LoadTasks();
            }
        }

        private async Task UpdateTaskStatus()
        {
            if (_view.SelectedTaskId.HasValue)
            {
                await _repository.UpdateTaskStatusAsync(_view.SelectedTaskId.Value, _view.SelectedTaskStatus);
                await LoadTasks();
            }
        }
    }
}
