using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            Customer customer1 = new Customer { Id = 1, FirstName = "Yakup", LastName = "Sayın", DateOfBirth = new DateTime(1990, 1, 10) };
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

            Console.WriteLine();

            GamesManager gameManager = new GamesManager();
            Game game1 = new Game { Name = "Grand Theft Auto V", Studio = "Rockstar Games", Price = 60 };
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            Console.WriteLine();
            
            Campaign campaign1 = new Campaign { Name = "PROMO30", Discount = 30 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine();

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(customer1, game1, campaign1);
        }
    }
}
