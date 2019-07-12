using System;

namespace ModelsLib
{
    public class DataContainer
    {
        #region properties

        private DateTime timestamp;
        private string euid;
        private ChemicalReading tgs2611Reading;
        private ChemicalReading tgs2602Reading;
        private ChemicalReading tgs2620Reading;
        private AtmosphericReading bme680Reading;


        public AtmosphericReading BME680Reading
        {
            get { return bme680Reading; }
            set { bme680Reading = value; }
        }
        public ChemicalReading TGS2620Reading
        {
            get { return tgs2620Reading; }
            set { tgs2620Reading = value; }
        }
        public ChemicalReading TGS2602Reading
        {
            get { return tgs2602Reading; }
            set { tgs2602Reading = value; }
        }
        public ChemicalReading TGS2611Reading
        {
            get { return tgs2611Reading; }
            set { tgs2611Reading = value; }
        }
        public string EUID
        {
            get { return euid; }
            set { euid = value; }
        }
        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        public PayloadHandler PayloadHdlr { get; set; }
        #endregion

        public DataContainer() { }
        public DataContainer(Telegram telegram)
        {
            timestamp = UnixTimeStampToDateTime(telegram.ts);
            euid = telegram.eui;
            PayloadHandler payloadHandler = new PayloadHandler(telegram);
            
            tgs2602Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2602Val);
            tgs2611Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2611Val);
            tgs2620Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2620Val);
            bme680Reading = new AtmosphericReading(Timestamp, payloadHandler.BMEPressure, payloadHandler.BMEHumidity, payloadHandler.BMETemperature, payloadHandler.BMEAirQuality);
        }



        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
