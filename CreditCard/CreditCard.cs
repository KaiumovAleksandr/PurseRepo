using System;

namespace CreditCard
{
    public class CreditCard
    {
        public int AmountMoney { get; set; }

        public CreditCard(int money) { AmountMoney = money; }

        public void ShowBalance() => Console.WriteLine($"Current balance : {AmountMoney}");
    }
}
