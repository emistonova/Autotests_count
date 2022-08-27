using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class Count
    {
        private string symbols;
        public Count(string symbols) => this.symbols = symbols;
        public int Symbols()
        {
            return symbols.Select(char.ToLowerInvariant).Distinct().Count();
        }
        public int Letters()
        {
            return symbols.Where(char.IsLetter).Select(char.ToLowerInvariant).Distinct().Count();
        }
        public int Numbers()
        {
            return symbols.Where(char.IsNumber).Distinct().Count();
        }
    }
}
