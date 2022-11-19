using System;

namespace TradingCommissions
{
    class TradingCommissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double tradingCommission = 0;

            switch (town)
            {
                case "Sofia":

                    if (0 <= sales && sales <= 500)
                    {
                        tradingCommission = sales * 0.05;
                        Console.WriteLine(tradingCommission);

                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        tradingCommission = sales * 0.07;
                        Console.WriteLine($"{ tradingCommission:f2}" );

                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        tradingCommission = sales * 0.08;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else if (10000 < sales)
                    {
                        tradingCommission = sales * 0.12;
                        Console.WriteLine($"{tradingCommission:f2}"); 

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        tradingCommission = (sales * 4.5) / 100;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        tradingCommission = sales * 0.075;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        tradingCommission = sales * 0.10;
                        Console.WriteLine("{ 0:f2}", tradingCommission);

                    }
                    else if (10000 < sales)
                    {
                        tradingCommission = sales * 0.13;
                        Console.WriteLine("{ 0:f2}", tradingCommission);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        tradingCommission = sales * 0.055;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        tradingCommission = sales * 0.08;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else if (1000 <= sales && sales <= 10000)
                    {
                        tradingCommission = sales * 0.12;
                        Console.WriteLine($"{tradingCommission:f2}");
                    }
                    else if (10000 < sales)
                    {
                        tradingCommission = sales * 0.145;
                        Console.WriteLine($"{tradingCommission:f2}");

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
