using FileAnalzyer.Model;

namespace FileAnalyzer.Presenter
{
    public class MainWindowPresenter
    {
        private readonly IMainWindowPresenter _view;
        private readonly TextFileAnalyzer _analyzer;

        public MainWindowPresenter(IMainWindowPresenter view)
        {
            _view = view;
            _analyzer = new TextFileAnalyzer();

            _view.AnalyzeFile += OnAnalyzeFile;
        }

        private void OnAnalyzeFile(object sender, EventArgs e)
        {
            try
            {
                _analyzer.AnalyzeFile(_view.FilePath);
                _view.DisplayAnalysisResults(_analyzer.WordCount, _analyzer.SentenceCount, _analyzer.CharacterCount);
            }
            catch (Exception ex)
            {
                throw new Exception($"Nie można sprawdzić pliku - {ex.Message}");
            }
        }
    }
}
