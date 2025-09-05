using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



namespace APITEST
{
    internal class TEDARIKCI
    {
        [JsonPropertyName("tedarikci_id")]
        public int TedarikciId { get; set; }

        [JsonPropertyName("unvan")]
        public string Unvan { get; set; }

        [JsonPropertyName("telefon")]
        public long Telefon { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("adres1")]
        public string Adres1 { get; set; }

        [JsonPropertyName("adres2")]
        public string Adres2 { get; set; }

        [JsonPropertyName("adres3")]
        public string Adres3 { get; set; }

        [JsonPropertyName("il")]
        public string Il { get; set; }

        [JsonPropertyName("ilce")]
        public string Ilce { get; set; }

        [JsonPropertyName("ulke")]
        public string Ulke { get; set; }

        [JsonPropertyName("vergi_dairesi")]
        public string VergiDairesi { get; set; }

        [JsonPropertyName("vergi_durumu")]
        public string VergiDurumu { get; set; }
    }
}
