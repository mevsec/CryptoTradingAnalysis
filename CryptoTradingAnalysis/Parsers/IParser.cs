using CryptoTradingAnalysis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTradingAnalysis.Parsers
{
    public interface IParser
    {
        Task<ICollection<IBalance>> ParseCSV(string fileLocation);
    }
}
