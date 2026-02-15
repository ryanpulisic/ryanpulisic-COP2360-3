// StockExample.cs
// Module 3: Classes, properties, object initialization, and formatted output.

using System;

namespace Module3Demo
{
    public class Stock
    {
        // Automatic properties (cleaner than backing fields for this use case).
        public decimal CurrentPrice { get; set; }
        public decimal SharesOwned { get; set; }

        // Calculated property: value derived from other data (no setter).
        public decimal Worth => CurrentPrice * SharesOwned;

        // Small helper method to print the object neatly.
        public void PrintSummary()
        {
            Console.WriteLine($"Price per share: {CurrentPrice:C}");
            Console.WriteLine($"Shares owned:    {SharesOwned:N0}");
            Console.WriteLine($"Total worth:     {Worth:C}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            // Object initializer: set properties at creation time.
            Stock portfolioItem = new Stock
            {
                CurrentPrice = 87.45m,
                SharesOwned = 120
            };

            Console.WriteLine("=== Stock Summary ===");
            portfolioItem.PrintSummary();

            // Demonstrate a simple update to show recalculation via Worth.
            portfolioItem.CurrentPrice = 92.10m;
            Console.WriteLine("\n=== After Price Update ===");
            portfolioItem.PrintSummary();

            // Local method: keeps small formatting logic close to where it’s used.
            static void Divider() => Console.WriteLine(new string('-', 28));
            Divider();
        }
    }
}
