using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibrary
{
    public class Money
    {
        public int Count { get; set; }
        public Money(int count) { Count = count; }
        public override string ToString()
        {
            return $"Money: {Count}$";
        }
    }
}
