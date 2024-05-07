using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class EUTIME
    {
        public class EuropeanDateTimePrinter : DateTimePrinter
        {
            public string GetCurrentDateTime()
            {
                DateTime current = DateTime.Now;
                CultureInfo culture = new CultureInfo("en-GB");
                return current.ToString("dd/MM/yyyy HH:mm:ss", culture);
            }
        }
    }
}
