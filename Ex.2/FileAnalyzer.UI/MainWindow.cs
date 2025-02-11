using FileAnalyzer.Presenter;

namespace FileAnalyzer.UI
{
    public partial class MainWindow : Form, IMainWindowPresenter
    {
        public MainWindow()
        {
            InitializeComponent();
            btnAnalyze.Click += (s, e) => AnalyzeFile?.Invoke(this, EventArgs.Empty);
        }
        public string FilePath => txtFilePath.Text;

        public event EventHandler AnalyzeFile;

        public void DisplayAnalysisResults(int words, int sentences, int characters)
        {
            listResults.Items.Clear();
            listResults.Items.Add($"Liczba s��w: {words}");
            listResults.Items.Add($"Liczba zda�: {sentences}");
            listResults.Items.Add($"Liczba znak�w: {characters}");
        }

    }
}
