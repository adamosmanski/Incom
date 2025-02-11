using System.Text.RegularExpressions;

namespace FileAnalzyer.Model
{
    public class TextFileAnalyzer
    {
        public int WordCount { get; private set; }
        public int SentenceCount { get; private set; }
        public int CharacterCount { get; private set; }

        public void AnalyzeFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Plik nie istnieje.");

            string content = File.ReadAllText(filePath);

            WordCount = Regex.Matches(content, @"\b\w+\b").Count;
            SentenceCount = Regex.Matches(content, @"[.!?]+").Count;
            CharacterCount = content.Length;
        }
    }
}
