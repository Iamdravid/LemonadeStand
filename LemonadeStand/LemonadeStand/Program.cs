using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Customer customer = new Customer();
            Weather weather = new Weather();
            Day day = new Day();
            Player player = new Player();
            double userLemPrice;
            int dayNumber = day.dayNumber;

            while (dayNumber <= 7)
            {
                double wallet = player.UpdateWallet();
                Inventory inventory = game.StartGame();


                userLemPrice = day.StartDay();

                customer.CreateCustomer(game);

                double funds = player.CustomerTransactions(wallet, inventory, customer.CustomerList, userLemPrice);
                Console.WriteLine("You're total for this week is: ${0}.", player.funds);

                dayNumber++;
            }







            Console.ReadLine();
        }
    }

}

