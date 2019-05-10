using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lets flip a coin 1000 times.");
            FlippingCoin();
        }

        private static void FlippingCoin()
        {
            int numberOfFlips = 1000;
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                int coinFlip = random.Next(1, 3);
                if (coinFlip == 1)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }
            Console.WriteLine("Number of coin flips: {0}", numberOfFlips);
            Console.WriteLine("Number of heads: {0}", headsCount);
            Console.WriteLine("Number of tails: {0}", tailsCount);
            Console.ReadLine();
        }
    }
}
