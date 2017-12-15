using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTradingAnalysis.Model
{
    public enum OrderType { Match, Fee, Deposit, Unknown };

    public class GdaxBalance : IBalance
    {
        public OrderType Order { get; set; }

        public DateTime Time { get; set; }

        public double Amount { get; set; }

        public double Balance { get; set; }

        public CurrencyType Currency { get; set; }

        public string TransferID { get; set; }

        public string OrderID { get; set; }

        public double Price { get; set; }
    }
}
