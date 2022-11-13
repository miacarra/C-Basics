using System;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice;
            if (product == "coffee")
            {
                switch (town)
                {
                    case "Sofia":
                        productPrice = quantity * 0.5;
                        Console.WriteLine(productPrice);
                        break;
                    case "Plovdiv":
                        productPrice = quantity * 0.4;
                        Console.WriteLine(productPrice);
                        break;
                    case "Varna":
                        productPrice = quantity * 0.45;
                        Console.WriteLine(productPrice);
                        break;
                }
            }

            else if (product == "water")
            {
                switch (town)
                {
                    case "Sofia":
                        productPrice = quantity * 0.8;
                        Console.WriteLine(productPrice);
                        break;
                    case "Plovdiv":
                        productPrice = quantity * 0.7;
                        Console.WriteLine(productPrice);
                        break;
                    case "Varna":
                        productPrice = quantity * 0.7;
                        Console.WriteLine(productPrice);
                        break;
                }

            }
            else if (product == "beer")
            {
                switch (town)
                {
                    case "Sofia":
                        productPrice = quantity * 1.2;
                        Console.WriteLine(productPrice);
                        break;
                    case "Plovdiv":
                        productPrice = quantity * 1.15;
                        Console.WriteLine(productPrice);
                        break;
                    case "Varna":
                        productPrice = quantity * 1.1;
                        Console.WriteLine(productPrice);
                        break;
                }
            }
            else if (product == "sweets")
            {
                switch (town)
                {
                    case "Sofia":
                        productPrice = quantity * 1.45;
                        Console.WriteLine(productPrice);
                        break;
                    case "Plovdiv":
                        productPrice = quantity * 1.3;
                        Console.WriteLine(productPrice);
                        break;
                    case "Varna":
                        productPrice = quantity * 1.35;
                        Console.WriteLine(productPrice);
                        break;
                }
            }
            else if (product == "peanuts")
            {
                switch (town)
                {
                    case "Sofia":
                        productPrice = quantity * 1.6;
                        Console.WriteLine(productPrice);
                        break;
                    case "Plovdiv":`
                        productPrice = quantity * 1.5;
                        Console.WriteLine(productPrice);
                        break;
                    case "Varna":
                        productPrice = quantity * 1.55;
                        Console.WriteLine(productPrice);
                        break;
                }
            }
        }
            }
}
