using System;
using log4net;
using System.Reflection;

namespace ModelsLib
{
    public class DataContainer
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
            log.Info("Creating DataContainer object from telegram");
            euid = telegram.eui;

            try { timestamp = Utils.UnixTimeStampToDateTime(telegram.ts); }
            catch (Exception e) { log.Error($"While converting to DateTime format, DataContainer has encountered the following exception: {e}"); }


            PayloadHandler payloadHandler = new PayloadHandler(telegram);
            try
            {
                tgs2602Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2602Val);
                tgs2611Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2611Val);
                tgs2620Reading = new ChemicalReading(Timestamp, payloadHandler.TGS2620Val);
                bme680Reading = new AtmosphericReading(Timestamp, payloadHandler.BMEPressure, payloadHandler.BMEHumidity, payloadHandler.BMETemperature, payloadHandler.BMEAirQuality);
            }
            catch (Exception e) { log.Error($"While converting telegram to Readings, DataContainer has encountered the following exception: {e}"); }

            log.Info("DataContainer with associated Reading-objects created. ");
        }


    }
}
