using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CurrencyApp.Model
{
    public class TableNBP
    {
        [JsonPropertyName("table")]
        public string Table { get; set; }

        [JsonPropertyName("no")]
        public string No { get; set; }

        [JsonPropertyName("effectiveDate")]
        public DateTime EffectiveDate { get; set; }

        [JsonPropertyName("rates")]
        public List<ExchangeRate> Rates { get; set; }
    }
}
