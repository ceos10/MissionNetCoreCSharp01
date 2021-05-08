using System;
using System.Collections.Generic;
using System.Linq;
using MissionNetCoreCSharp01.Models;

namespace MissionNetCoreCSharp01
{
    public class Loops
    {
        public Loops()
        {
            Console.WriteLine("Loops");
        }

        // Insert the odd numbers from list1 to oddNumbersList
        // Print the values of oddNumbersList
        // Use the Do While statement
        public void DoStatement()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNumbersList = list1.Where(p => p%2 != 0).ToList();

            int i = 0;
            do
            {
                Console.WriteLine(oddNumbersList[i]);
                i++;
            } while (i < oddNumbersList.Count);
        }

        // Compute sum of first n natural numbers
        // Print the value of the sum
        // Use the For Statement
        public void ForStatement()
        {
            var n = 10;
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of first {n} numbers: {sum}");
        }

        // Print the name of the products included on the list
        // Use the foreach statement
        public void ForEachStatement()
        {
            var orderProducts = new List<Product>()
            {
                new Product() { Name = "Product A"},
                new Product() { Name = "Product B"},
                new Product() { Name = "Product C"}
            };

            foreach (var product in orderProducts)
            {
                Console.WriteLine(product.Name);
            }
        }

        // Compute the sum of the first n natural numbers
        // Print the value of the sum
        // Use the While statement
        public void WhileStatement()
        {
            var i = 1;
            var n = 10;
            var sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine($"Sum of first {n} numbers: {sum}");
        }
    }
}