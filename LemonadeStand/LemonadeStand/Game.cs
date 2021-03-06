﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player = new Player();
        Day day = new Day();
        Inventory currInventory = new Inventory();
        Wallet wallet;
        public int dayTemp;
        public string dayCond;

        public Game()
        {
            Console.WriteLine("Welcome too your very own Lemonade Stand!");
            Console.WriteLine("\nRules here are simple: ");
            Console.WriteLine("\n* Your goal is to make as much as you can in seven days. \n* Make sure to buy your products daily, if not, they may spoil and you'll have unhappy customers! \n* Keep an eye on the forecast and plan accordingly.");
            Console.WriteLine("\nBest of Luck!");
            Console.Read();
            Console.Clear();

            Console.WriteLine("Before we start, what is your name?");
            Console.ReadLine();
            player.name = Console.ReadLine();
            Console.WriteLine("\nHi, Nice to meet you {0}!", player.getName());
            Console.ReadLine();
            Console.Clear();
        }
        public Inventory StartGame()
        {
            day.PrintDayWeather();
            dayTemp = day.degrees;
            dayCond = day.condition;
            player.inventory.PrintCurrentInventory();

            player.PlayerUpdateWallet();

            Console.WriteLine("\nLet's purchase some ingredients for your Lemonade.");
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();

            currInventory = player.GoBuyMaterials();

            return currInventory;

        }
    }
}
