using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CryptoTradingAnalysis.Model;

namespace CryptoTradingAnalysis.Parsers
{
    public class GdaxParser : IParser
    {
        private OrderType GetOrderType(string item)
        {
            switch (item)
            {
                case "match":
                    return OrderType.Match;
                case "fee":
                    return OrderType.Fee;
                case "deposit":
                    return OrderType.Deposit;
                default:
                    return OrderType.Unknown;
            }
        }

        private DateTime GetTimeStamp(string item)
        {
            return DateTime.Parse(item);
        }

        private double GetAmount(string item)
        {
            return double.Parse(item);
        }

        private double GetBalance(string item)
        {
            return double.Parse(item);
        }

        private CurrencyType GetCurrency(string item)
        {
            switch (item)
            {
                case "LTC":
                    return CurrencyType.Litecoin;
                case "BTC":
                    return CurrencyType.Bitcoin;
                case "ETH":
                    return CurrencyType.Ethereum;
                case "USD":
                    return CurrencyType.USD;
                default:
                    return CurrencyType.Unknown;
            }
        }

        public async Task<ICollection<IBalance>> ParseCSV(string fileLocation)
        {
            var items = new List<IBalance>();
            var lines = await Util.ReadAllLinesAsync(fileLocation);
            
            foreach (var item in lines.Skip(1))
            {
                var entries = item.Split(',');
                items.Add(new GdaxBalance()
                {
                    Order = GetOrderType(entries[0]),
                    Time = GetTimeStamp(entries[1]),
                    Amount = GetAmount(entries[2]),
                    Balance = GetBalance(entries[3]),
                    Currency = GetCurrency(entries[4]),
                });
            }
            return items;
        }
    }
}