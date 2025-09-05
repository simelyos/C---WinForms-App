using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APITEST
{
    internal class BIRIM
    {
        [JsonPropertyName("birim_id")]
        public int BirimID { get; set; }

        [JsonPropertyName("birim_adi")]
        public string BirimAdi { get; set; }

        [JsonPropertyName("adres1")]
        public string Adres1 { get; set; }

        [JsonPropertyName("adres2")]
        public string Adres2 { get; set; }

        [JsonPropertyName("adres3")]
        public string Adres3 { get; set; }

        [JsonPropertyName("ilce")]
        public string Ilce { get; set; }

        [JsonPropertyName("il")]
        public string Il { get; set; }

        [JsonPropertyName("ulke")]
        public string Ulke { get; set; }

        [JsonPropertyName("telefon")]
        public long Telefon { get; set; }

        [JsonPropertyName("birim_sorumlusu")]
        public string BirimSorumlusu { get; set; }

        [JsonPropertyName("acik_kapali")]
        public string AcıkKapalı { get; set; }

        [JsonPropertyName("birim_tipi")]
        public string BirimTip { get; set; }

    }


}
