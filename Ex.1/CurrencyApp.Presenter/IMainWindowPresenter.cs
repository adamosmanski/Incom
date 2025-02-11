using CurrencyApp.Model;

namespace CurrencyApp.Presenter
{
    public interface IMainWindowPresenter
    {
        int selectedYear { get; set; }
        int selectedMonth { get; set; }
        void DisplayExchangeRates(List<ExchangeRate> rates);
        event EventHandler OnGetCurrentRatesClicked;
        event EventHandler OnGetArchivedRatesClicked;
    }
}
