using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Decorator
    {
        public class CustomSymbolDecorator : DateTimePrinter
        {
            private readonly DateTimePrinter _dateTimePrinter;
            private readonly string _customSymbol;
            private readonly string _customSymbol2;

            public CustomSymbolDecorator(DateTimePrinter dateTimePrinter, string customSymbol, string customSymbol2)
            {
                _dateTimePrinter = dateTimePrinter;
                _customSymbol = customSymbol;
                _customSymbol2 = customSymbol2;
            }

            public string GetCurrentDateTime()
            {
                string currentDateTime = _dateTimePrinter.GetCurrentDateTime();
                StringBuilder builder = new StringBuilder();
                builder.Append(_customSymbol);
                builder.Append(currentDateTime);
                builder.Append(_customSymbol2);
                return builder.ToString();
            }
        }
    }
}
