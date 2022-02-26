using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> market = new Dictionary<string, List<double>>();
            double s = 0;
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                string goods = line[0];
                if (goods=="stocked")
                {
                    break;

                }

                double price = double.Parse(line[1]);
                double quantity = double.Parse(line[2]); 


                if (market.ContainsKey(goods))
                {
                    if (market[goods][0]!=price)
                    {
                        market[goods][0] = price;
                    }
                    market[goods][1] += quantity;
                }
                else
                {
                    var priceandquantity = new List<double>();
                    priceandquantity.Add(price);
                    priceandquantity.Add(quantity);
                    market.Add(goods, priceandquantity);

                }

            }
            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]:f2} = ${item.Value[0]*item.Value[1]:f2}");
                s += item.Value[0] * item.Value[1];
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${s:f2}");

        }
    }
}
