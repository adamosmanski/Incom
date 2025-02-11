using CurrencyApp.API;
using CurrencyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.Presenter
{
    public class MainWindowPresenter
    {
        private readonly IMainWindowPresenter _view;
        private readonly NBPService _api;

        public MainWindowPresenter(IMainWindowPresenter view)
        {
            _view = view;
            _api = new NBPService();
            _view.OnGetCurrentRatesClicked += async (s, e) => await GetRates();
            _view.OnGetArchivedRatesClicked += async (s, e) => await GetArchivedRates();
        }

        private async Task GetRates()
        {
            var rates = await _api.GetCurrencyRatesAsync();
            _view.DisplayExchangeRates(rates);
        }

        private async Task GetArchivedRates()
        {
            int year = _view.selectedYear;
            int month = _view.selectedMonth;
            var rates = await _api.GetArchivedRatesAsync(year, month);
            _view.DisplayExchangeRates(rates);

        }
    }
}
