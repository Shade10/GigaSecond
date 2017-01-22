using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaSecond
{
    public class Gigasecond
    {
        private static TimeSpan GigaSecond = new TimeSpan(0,0, 1000000000);
        public static DateTime Date(DateTime dateNow)
        {
            return dateNow.Add(GigaSecond);
        }

    }
}
