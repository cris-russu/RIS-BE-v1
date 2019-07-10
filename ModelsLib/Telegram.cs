using System;

namespace ModelsLib
{
    public class Telegram
    {
        private string euid;
        private string payload;
        private DateTime timestamp;

        public DateTime Timestamp
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

        public Telegram() { }
        public Telegram(string rawStr)
        {
            //TODO: insert string parsing method
        }


    }
}
