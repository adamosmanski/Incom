using CurrencyApp.Model;
using CurrencyApp.Presenter;

namespace CurrencyApp.UI
{
    public partial class MainWindow : Form, IMainWindowPresenter
    {
        public event EventHandler OnGetCurrentRatesClicked;
        public event EventHandler OnGetArchivedRatesClicked;
        private readonly MainWindowPresenter _presenter;

        public int selectedMonth
        {
            get => (int)((KeyValuePair<int, string>)cmbMonth.SelectedItem).Key;
            set => cmbMonth.SelectedItem = new KeyValuePair<int, string>(value, months[value]);
        }

        public int selectedYear
        {
            get => int.TryParse(txtYear.Text, out int year) ? year : DateTime.Now.Year-1;
            set => txtYear.Text = value.ToString();
        }
        private Dictionary<int, string> months;


        public MainWindow()
        {
            InitializeComponent();
            _presenter = new MainWindowPresenter(this);
            LoadMonths();
            btnFetchCurrent.Click += (s, e) => OnGetCurrentRatesClicked?.Invoke(this, EventArgs.Empty);
            btnFetchHistorical.Click += (s, e) => OnGetArchivedRatesClicked?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayExchangeRates(List<ExchangeRate> rates)
        {
            dgv_rates.DataSource = null;
            dgv_rates.DataSource = rates;
            if (!dgv_rates.Columns.Contains("Date"))
            {
                dgv_rates.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Date",
                    HeaderText = "Data",
                    DataPropertyName = "Date",
                    ValueType = typeof(DateTime),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });
            }
        }
        private void LoadMonths()
        {
            months = new Dictionary<int, string>
            {
                {1, "Styczeñ"}, {2, "Luty"}, {3, "Marzec"}, {4, "Kwiecieñ"},
                {5, "Maj"}, {6, "Czerwiec"}, {7, "Lipiec"}, {8, "Sierpieñ"},
                {9, "Wrzesieñ"}, {10, "PaŸdziernik"}, {11, "Listopad"}, {12, "Grudzieñ"}
            };

            cmbMonth.DataSource = new BindingSource(months, null);
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "Key";
        }
    }
}