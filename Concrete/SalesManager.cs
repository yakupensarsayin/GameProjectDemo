using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("     Player : " + customer.FirstName + " - " + customer.LastName);
            Console.WriteLine("Game to buy : " + game.Name);
            Console.WriteLine(" Game price : " + game.Price + " TL");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(campaign.Name + " Discount rate : % " + campaign.Discount);

            double price;
            price = (game.Price) - (game.Price * campaign.Discount) / 100;

            Console.WriteLine("Discount price : " + price + " TL");
        }
    }
}
