using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    class Program
    {
        static void Main(string[] args)
        {
            // voor auto
            double AeK = 0.20;
            double free = 100;
            double ADaily = 50;

            // voor busje
            double BeK = 0.30;
            double BDaily = 95;

            // voor beiden
            double perLitre = 0.65;

            // variabelen
            double TotalCost;
            double KmCost;
            double TotalDayCost;

            // math
            Console.WriteLine("How many litres did you tank?");
            double tanked = Convert.ToDouble(Console.ReadLine());
            double tankCost = tanked * perLitre;
            Console.WriteLine("How many days did you drive?");
            double days = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many kilometers did you drive?");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("What vehicle did you drive?(Car/Van)");
                string vehicle = Convert.ToString(Console.ReadLine());
                if (vehicle == "Car")
                {
                    KmCost = (kilometers - (free * days)) * AeK;
                    if (KmCost <= 0)
                    {
                        KmCost = 0;
                    }
                    TotalDayCost = days * ADaily;
                    TotalCost = KmCost + TotalDayCost + tankCost;
                    break;
                }
                else if (vehicle == "Van")
                {
                    KmCost = kilometers * BeK;
                    TotalDayCost = days * BDaily;
                    TotalCost = KmCost + TotalDayCost + tankCost;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Try again.");
                }
            }
            Console.WriteLine("The total costs are: " + TotalCost + " Euro's.");
            Console.WriteLine("The total fuel costs are: " + tankCost + " Euro's.");
            Console.WriteLine("The total costs for driving are: " + KmCost + " Euro's.");
            Console.WriteLine("The total rent costs are: " + TotalDayCost + " Euro's.");
            Console.ReadLine();
        }
    }
}
// Personenauto:
    // 0,20 euro per kilometer
    // per dag 100 kilometer gratis
    // 50 euro per dag
//personenbusje:
    // 0,30 euro per kilometer
    // 95 euro per dag
// auto begint met volle tank
// bereken te betalen bedrag
// getankte benzine moet meegerekend worden.
