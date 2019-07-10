using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class ClearingLog
    {
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

    }
}
