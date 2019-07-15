using System.Collections.Generic;
using System.Linq;
using log4net;
using System.Reflection;
using System;

namespace ModelsLib
{
    public class PayloadHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public string InitialString { get; set; }
        public ushort TGS2602Val { get; set; }
        public ushort TGS2611Val { get; set; }
        public ushort TGS2620Val { get; set; }
        public byte BMEHumidity { get; set; }
        public ushort BMEPressure { get; set; }
        public sbyte BMETemperature { get; set; }
        public byte BMEAirQuality { get; set; }
        public List<string> KeyValueList { get; set; }

        public PayloadHandler() { }
        public PayloadHandler(string oneTelegramString)
        {
            InitialString = oneTelegramString;
        }

        public PayloadHandler(Telegram telegram)
        {
            InitialString = telegram.data;
            SplitPayload();
            SetPayloadNumericValues();
        }

        public void SplitPayload()
        {
            try { KeyValueList = Utils.Split(InitialString, 2).ToList(); }
            catch (Exception e) { log.Error($"SplitPayload() has encountered the following exception: {e}"); }
        }

        public void SetPayloadNumericValues()
        {
            try
            {
                TGS2602Val = ushort.Parse(KeyValueList.ElementAt(0) + KeyValueList.ElementAt(1), System.Globalization.NumberStyles.HexNumber);
                TGS2611Val = ushort.Parse(KeyValueList.ElementAt(2) + KeyValueList.ElementAt(3), System.Globalization.NumberStyles.HexNumber);
                TGS2620Val = ushort.Parse(KeyValueList.ElementAt(4) + KeyValueList.ElementAt(5), System.Globalization.NumberStyles.HexNumber);
                BMEHumidity = byte.Parse(KeyValueList.ElementAt(6), System.Globalization.NumberStyles.HexNumber);
                BMEPressure = ushort.Parse(KeyValueList.ElementAt(7) + KeyValueList.ElementAt(8), System.Globalization.NumberStyles.HexNumber);
                BMETemperature = (sbyte)(128 - sbyte.Parse(KeyValueList.ElementAt(9), System.Globalization.NumberStyles.HexNumber));
                BMEAirQuality = byte.Parse(KeyValueList.ElementAt(10), System.Globalization.NumberStyles.HexNumber);
            }
            catch (Exception e) { log.Error($"SetPayloadNumericValues has encountered the following exception: {e}"); }
        }


    }
}
