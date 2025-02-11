using System.Text.Json.Serialization;

namespace CurrencyApp.Model
{
    public class ExchangeRate
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("mid")]
        public decimal Mid { get; set; }

        public DateTime Date { get; set; }
    }
}
