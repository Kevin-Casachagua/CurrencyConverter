using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterLibreria
{
    public enum CurrencyType
    {
        US,
        AUS,
        UK,
    }
    public class ConvertibleCurrency
    {
        private decimal amount;
        private CurrencyType currency;

        private decimal AusInUS = 2;
        private decimal UKInUS = 0.5M;

        public ConvertibleCurrency(CurrencyType type, decimal val)
        {
            currency = type;
            amount = val;
        }

        public decimal ConvertTo(CurrencyType type)
        {
            decimal converted = amount;
            if (currency == CurrencyType.UK)
            {
                converted = converted / UKInUS;
            }
            else if (currency == CurrencyType.AUS)
            {
                converted = converted / AusInUS;
            }

            if (type == CurrencyType.UK)
            {
                converted = converted * UKInUS;
            }
            else if (type == CurrencyType.AUS)
            {
                converted = converted * AusInUS;
            }
            return converted;
        }

    }
}
