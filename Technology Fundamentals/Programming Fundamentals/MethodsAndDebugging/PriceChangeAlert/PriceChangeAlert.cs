    using System;

    public class PriceChangeAlert
    {
        static void Main()
        {
            int numberPrices = int.Parse(Console.ReadLine());
            double percentChange = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            for (int i = 0; i < numberPrices - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double substractPercent = calcPercent(price, nextPrice);
                bool difference = Difference(substractPercent, percentChange);
                string message = Get(nextPrice, price, substractPercent, difference);

                Console.WriteLine(message);

                price = nextPrice;
            }
        }

        public static string Get(double nextPrice, double price, double subtractPercent, bool difference)
        {
            string message = string.Empty;

            if (subtractPercent == 0)
            {
                message = string.Format("NO CHANGE: {0}", nextPrice);
            }
            else if (!difference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, subtractPercent);
            }
            else if (difference && (subtractPercent > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, subtractPercent);
            }
            else if (difference && (subtractPercent < -10))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, subtractPercent);
            }

            return message;
        }
        public static bool Difference(double substractPercent, double percentChange)
        {
            if (Math.Abs(substractPercent) > percentChange)
            {
                return true;
            }
            
                return false;
        }

        public static double calcPercent(double price, double nextPrice)
        {
            double result = (nextPrice - price) / price *100;

            return result;
        }
    }
