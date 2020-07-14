/// This program will return minimum two coins for getting the sums

using System;
using System.Collections.Generic;

namespace CoinProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass t = new TestClass();
            //t.ReadLinePlaceinArray();

           PrintListOfCoins();

        }

        private static void PrintListOfCoins()
        {
            List<int> listOfCoins = new List<int>();
            listOfCoins.Add(9);
            listOfCoins.Add(6);
            listOfCoins.Add(5);
            listOfCoins.Add(1);

            int coinSum = 15;


            if (FindMinCoins(listOfCoins, coinSum).Count == 0)
            { Console.WriteLine("Sum from the given list of coins cannot be calculated"); }
            else
            {
                string s = FindMinCoins(listOfCoins, coinSum)[0].ToString() + " " + FindMinCoins(listOfCoins, coinSum)[1].ToString();

                Console.WriteLine(s);
            }

        }

        private static List<int> FindMinCoins(List<int> listOfCoins, int coinSum)
        {
            int total, firstCoinToSum,  secondCoinToSum;
            List<int> finalListOfCoins = new List<int>();

            listOfCoins.Sort();

            // 1 5 6 9
            for (int i = 0; i < listOfCoins.Count; i++)
            {
               firstCoinToSum =  listOfCoins[i];

                for (int j = 0; j < listOfCoins.Count; j++)
                {
                    secondCoinToSum = listOfCoins[j];
                    total = firstCoinToSum + secondCoinToSum;

                    if (total == coinSum)
                    {
                        finalListOfCoins.Add(listOfCoins[i]);
                        finalListOfCoins.Add(listOfCoins[j]);
                        return finalListOfCoins;
                    }
                    
                }
            }

            return finalListOfCoins;

        }
    }
}
