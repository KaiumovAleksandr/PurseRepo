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
            var card = new Card.CreditCard(100);
            card.ShowBalance();          
            BusinessCard.BusinessCard businessCard = new BusinessCard.BusinessCard() { NumberCard = 56 };
            businessCard.ShowNumberCard();
            Console.ReadLine();
        }
    }
}
