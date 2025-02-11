using ToDoList.Model.ToDoList.Model;
using ToDoList.Presenter;
using TaskStatus = ToDoList.Model.ToDoList.Model.TaskStatus;

namespace ToDoList.UI
{
    public partial class MainWindow : Form, IMainWindowView
    {
        public string NewTaskDescription
        {
            get => txtTaskDescription.Text;  
            set => txtTaskDescription.Text = value;
        }

        public int? SelectedTaskId
        {
            get
            {
                if (dgvTasks.SelectedRows.Count > 0)
                {
                    return (int?)dgvTasks.SelectedRows[0].Cells["Id"].Value; 
                }
                return null;
            }
            set
            {
                if (dgvTasks.Rows.Count > 0 && value.HasValue)
                {
                    foreach (DataGridViewRow row in dgvTasks.Rows)
                    {
                        if ((int)row.Cells["Id"].Value == value.Value)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        public TaskStatus SelectedTaskStatus
        {
            get => (TaskStatus)cmbStatus.SelectedItem;
            set => cmbStatus.SelectedItem = value;
        }

        public event EventHandler OnTaskAdded;
        public event EventHandler OnTaskRemoved;
        public event EventHandler OnTaskUpdated;
        private MainWindowPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            _presenter = new MainWindowPresenter(this);
            _presenter.LoadTasks();
            LoadStatus();
            btnAddTask.Click += (s, e) => OnTaskAdded?.Invoke(this,EventArgs.Empty);
            btnRemoveTask.Click += (s, e) => OnTaskRemoved?.Invoke(this, EventArgs.Empty);
            btnAcceptChange.Click += (s, e) => OnTaskUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void ShowTasks(List<TaskItem> tasks)
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }

        private void LoadStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
        }
    }
}