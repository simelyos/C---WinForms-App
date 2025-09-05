using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APITEST
{
    internal class URUN
    {

        [JsonPropertyName("urun_id")]
        public int UrunId { get; set; }

        [JsonPropertyName("urun_adi")]
        public string UrunAdi { get; set; }

        [JsonPropertyName("alis_birimi")]
        public string AlisBirimi { get; set; }

        [JsonPropertyName("satis_birimi")]
        public string SatisBirimi { get; set; }

        [JsonPropertyName("alis_fiyati")]
        public decimal AlisFiyati { get; set; }

        [JsonPropertyName("satis_fiyati")]
        public decimal SatisFiyati { get; set; }

        [JsonPropertyName("satis_durumu")]
        public string SatisDurumu { get; set; }

        [JsonPropertyName("ithal_yerli")]
        public string IthalYerli { get; set; }

        [JsonPropertyName("tedarikci_id")]
        public int TedarikciId { get; set; }

        [JsonPropertyName("birim_id")]
        public int BirimId { get; set; }

        [JsonPropertyName("barkod_id")]
        public int BarkodId { get; set; }

        [JsonPropertyName("barkod")]
        public string Barkod { get; set; }




















    }
}
