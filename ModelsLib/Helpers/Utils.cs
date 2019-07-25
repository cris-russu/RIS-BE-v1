using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public static class Utils
    {
        /// <summary>
        /// splits a string into n-sized chunks
        /// </summary>
        /// <param name="str"></param>
        /// <param name="chunkSize"></param>
        /// <returns>IEnumerable<string> with each string of n-letters long</returns>
        public static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
        
        /// <summary>
        /// Converts Unix Timestamp into DateTime object
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns>DateTime object</returns>
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static void CopyPropertiesTo<T, TU>(this T source, TU dest)
        {
            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).Skip(1).ToList();
            var destProps = typeof(TU).GetProperties()
                    .Where(x => x.CanWrite)
                    .ToList();

            foreach (var sourceProp in sourceProps)
            {
                if (destProps.Any(x => x.Name == sourceProp.Name))
                {
                    var p = destProps.First(x => x.Name == sourceProp.Name);
                    if (p.CanWrite)
                    {
                        p.SetValue(dest, sourceProp.GetValue(source, null), null);
                    }
                }

            }

        }
    }
}
