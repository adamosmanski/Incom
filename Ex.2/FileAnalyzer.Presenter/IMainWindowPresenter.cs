using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAnalyzer.Presenter
{
    public interface IMainWindowPresenter
    {
        string FilePath { get; }
        void DisplayAnalysisResults(int words, int sentences, int characters);
        event EventHandler AnalyzeFile;
    }
}
