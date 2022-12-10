using System;
using System.Collections.Generic;

namespace HwOnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            (string, string) userInfo = ("Vasyl", "Petrov");
            User user = new User(userInfo, shop);
            user.LookProducts();
            Console.ReadLine();
            user.LookCart();
            Console.ReadLine();
            user.MakeOrder();
        }
    }
}