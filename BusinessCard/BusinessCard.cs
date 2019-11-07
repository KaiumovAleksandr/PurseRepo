using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCard
{
    public class BusinessCard
    {
        public int NumberCard { get; set; }
        public void ShowNumberCard()
        {
            Console.WriteLine($"Number Card: {NumberCard}");
        }
    }
}
