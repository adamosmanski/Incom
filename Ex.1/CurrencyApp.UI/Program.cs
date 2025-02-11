using CurrencyApp.Presenter;
using Serilog;
using System.Windows.Forms;

namespace CurrencyApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("Logs/log-.txt",
                    rollingInterval: RollingInterval.Hour,
                    retainedFileCountLimit: 24,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}")
                .CreateLogger();

            try
            {
                Log.Information("Aplikacja startuje...");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Aplikacja zakoñczy³a dzia³anie z b³êdem.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}