using System;

namespace ModelsLib
{
    public class DataContainer
    {
        private DateTime timestamp;
        private string euid;
        private ChemicalReading methaneReading;
        private ChemicalReading ammoniaReading;
        private ChemicalReading sulfurReading;
        private AtmosphericReading atmReading;
        //TODO: rename to the correct sensors' names

        public AtmosphericReading AtmReading
        {
            get { return atmReading; }
            set { atmReading = value; }
        }
        public ChemicalReading SulfurReading
        {
            get { return sulfurReading; }
            set { sulfurReading = value; }
        }
        public ChemicalReading AmmoniaReading
        {
            get { return ammoniaReading; }
            set { ammoniaReading = value; }
        }
        public ChemicalReading MethaneReading
        {
            get { return methaneReading; }
            set { methaneReading = value; }
        }
        public string EUID
        {
            get { return euid; }
            set { euid = value; }
        }
        public DateTime TImestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public DataContainer() { }
        public DataContainer(Telegram telegram)
        {
            timestamp = telegram.Timestamp;
            euid = telegram.EUID;
            //TODO: insert parsing of telegram's payload method for each of the DataContainer's properties
        }
    }
}
