using System;
using MoneyLibrary;



namespace PurseGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(45896);
            Console.WriteLine(money);
            var card = new CreditCard.CreditCard(100);
            card.ShowBalance();
            Console.ReadLine();
        }
    }
}
