using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class AMTIME
    {
        public class AmericanDateTimePrinter : DateTimePrinter
        {
            public string GetCurrentDateTime()
            {
                DateTime current = DateTime.Now;
                CultureInfo cultureInfo = new CultureInfo("en-US");
                return current.ToString("MM/dd/yyyy HH:mm:ss", cultureInfo);
            }
        }
    }
}
