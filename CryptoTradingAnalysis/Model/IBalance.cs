using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTradingAnalysis.Model
{
    public enum CurrencyType { Bitcoin, Ethereum, Litecoin, USD, Unknown};
    public interface IBalance
    {
        DateTime Time { get; set; }

        double Amount { get; set; }

        double Balance { get; set; }

        CurrencyType Currency { get; set; }

        double Price { get; set; }
    }
}
