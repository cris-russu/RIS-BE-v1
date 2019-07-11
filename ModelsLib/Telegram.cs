using Newtonsoft.Json;

namespace ModelsLib
{
    public class Telegram
    {
        #region properties and empty ctor

        public readonly string cmd = "rx";
        public string eui { get; set; } //16 hex digits
        public double ts { get; set; } //server timestamp as number (milliseconds from Linux epoch)
        public bool ack { get; set; }
        public int fnct { get; set; } // frame counter, a 32-bit number
        public int port { get; set; }
        public string data { get; set; } // hex string 
        public long freq { get; set; }
        public int rssi { get; set; } // frame rssi, in dBm, as int
        public double snr { get; set; } // fram snr, in dBm, one decimal place

        public Telegram() { }
        #endregion
        
        public Telegram GetTelegram(string rawJson) => JsonConvert.DeserializeObject<Telegram>(rawJson);
        
        public string ConvertToJson() => JsonConvert.SerializeObject(this); 
        
    }
}
