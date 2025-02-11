using CurrencyApp.Model;
using Serilog;
using System.Text.Json;

namespace CurrencyApp.API
{

    public class NBPService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<ExchangeRate>> GetCurrencyRatesAsync()
        {
            string url = "http://api.nbp.pl/api/exchangerates/tables/A/?format=json";
            Log.Information($"CurrencyApi - GetCurrencyRatesAsync - Get data from {url}");
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var data = JsonSerializer.Deserialize<List<TableNBP>>(response, options);
                Log.Information($"{data}");
                return data?[0]?.Rates ?? new List<ExchangeRate>();
            }
            catch (Exception ex)
            {
                Log.Error($"CurrencyApi - GetCurrencyRatesAsync - Cannot get data from {url}. Try again later.");
                Log.Error($"{ex.Message}");
                return new List<ExchangeRate>();
            }
        }
        public async Task<List<ExchangeRate>> GetArchivedRatesAsync(int year, int month)
        {
            var allRates = new List<ExchangeRate>();
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                string date = $"{year}-{month:D2}-{day:D2}";
                string url = $"http://api.nbp.pl/api/exchangerates/tables/A/{date}/?format=json";

                try
                {
                    var response = await _httpClient.GetStringAsync(url);
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var data = JsonSerializer.Deserialize<List<TableNBP>>(response, options);

                    if (data != null && data.Count > 0)
                    {
                        foreach (var rate in data[0].Rates)
                        {
                            rate.Date = DateTime.Parse(date);
                        }
                        allRates.AddRange(data[0].Rates);
                    }
                }
                catch (HttpRequestException ex)
                {
                    Log.Warning($"CurrencyApi - GetCurrencyRatesAsync - Data doesn't exist for {date}... ({ex.Message})");
                    continue;
                }
                catch (Exception ex)
                {
                    Log.Error($"CurrencyApi - GetCurrencyRatesAsync - Cannot get data from {date}: {ex.Message}");
                }
            }

            return allRates;
        }

    }
}