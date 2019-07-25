using System;
using System.Data.Linq.Mapping;

namespace ModelsLib
{
    [Table(Name = "ClearingLogs")]
    public class ClearingLog
    {
        #region properties

        private DateTime date;
        private int binId;
        private int _id;
        [Column(IsDbGenerated = true, IsPrimaryKey =true, Storage = "_id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Storage = "binId")]
        public int BinId
        {
            get { return binId; }
            set { binId = value; }
        }
        [Column(Storage = "date")]
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
