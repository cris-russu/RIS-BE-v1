using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
