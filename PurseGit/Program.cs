using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLibrary;

namespace PurseGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(45896);
            Console.WriteLine(money);
        }
    }
}
