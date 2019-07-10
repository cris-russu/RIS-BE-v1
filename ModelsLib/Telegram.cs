using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class Telegram
    {
        private string euid;
        private string payload;
        private string timestamp;

        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        public string Payload
        {
            get { return payload; }
            set { payload = value; }
        }
        public string EUID
        {
            get { return euid; }
            set { euid = value; }
        }

    }
}
