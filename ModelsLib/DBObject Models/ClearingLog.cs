using System;

namespace ModelsLib
{
    public class ClearingLog
    {
        #region properties

        private DateTime date;
        private int binId;

        public int BinId
        {
            get { return binId; }
            set { binId = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        #endregion

        public ClearingLog() { }
        public ClearingLog(DateTime dt, int bin)
        {
            date = dt;
            binId = bin; 
        }
    }
}
