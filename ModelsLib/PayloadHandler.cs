using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class PayloadHandler
    {
        public string InitialString { get; set; }
        public ushort TGS2602Val { get; set; }
        public ushort TGS2611Val { get; set; }
        public ushort TGS2620Val { get; set; }
        public byte BMEHumidity { get; set; }
        public ushort BMEPressure { get; set; }
        public sbyte BMETemperature { get; set; }
        public byte BMEAirQuality { get; set; }

        public PayloadHandler() { }
        public PayloadHandler(Telegram telegram)
        {
                
        }

        public static void SplitPayload(string rawPayload)
        {
            //todo: change return to string array of length of # of properties of this class
        }
    }
}
