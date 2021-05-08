using System;
using System.Collections.Generic;
using MissionNetCoreCSharp01.Enums;

namespace MissionNetCoreCSharp01
{
    public class Conditionals
    {
        public Conditionals()
        {
            Console.WriteLine("Conditionals");
        }

        // Write to the result variable the string Positive or Negative depending on the value of the Number
        // Use the ternary conditional operator ?:
        public void TernaryConditionalOperator()
        {
            int number = new Random().Next(-5, 5);
            var result = number < 0 ? "Negative": "Positive";
            var message = $"TernaryConditionalOperator, number({number}) : {result}";

            Console.Write(message);
        }

        // Write to the result variable the string Positive or Negative depending on the value of the Number
        // Use the if statement.
        public void IfStatement()
        {
            int number = new Random().Next(-5, 5);
            string result;
            if (number < 0)
                result = "Negative";
            else 
                result = "Positive";

            var message = $"IfStatement, number({number}) : {result}";

            Console.Write(message);
        }

        // Print the true table for the exclusive OR operator
        // User a loop to print the results
        public void BitwiseOperator()
        {
            var operator1 = new int[] {0,0,1,1};
            var operator2 = new int[] {0,1,0,1};

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{operator1[i]} ^ {operator2[i]} = {operator1[i] ^ operator2[i]}");
            }

        }

        // Print the size of the List of integers which value is different than null
        // Use the null-coalescing operator ??
        // use the resultList to store the result
        public void NullCoalescingOperator()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list2 = null;
            
            var list1Size = list1?.Count ?? 0;
            var list2Size = list1?.Count ?? 0;

            Console.WriteLine($"List1 size: {list1Size}");
            Console.WriteLine($"List2 size: {list2Size}");
        }

        // Print the list size of the list1
        // In case the list is null, initialize it as an empty list
        // Use the Null coalescing assignment Operator ??=
        public void NullCoalescingAssignmentOperator()
        {
            List<int> list1 = null;
            list1 ??= new List<int>();
            var listSize = list1.Count;

            Console.WriteLine($"List size: {listSize}");
        }

        // Print the Day of Week names using the enum WeekDays
        // Use the Switch Expression
        public void SwitchExpression()
        {
            var dayOfWeek = WeekDays.Friday;

            var nameOfDayOfWeek = dayOfWeek switch
            {
                WeekDays.Monday => "Monday",
                WeekDays.Tuesday => "Tuesday",
                WeekDays.Wednesday => "Wednesday",
                WeekDays.Thursday => "Thursday",
                WeekDays.Friday => "Friday",
                WeekDays.Saturday => "Saturday",
                WeekDays.Sunday => "Sunday",
                _ => ""
            };

            var message = $"Name of Day: {nameOfDayOfWeek}";

            Console.Write(message);
        }


    }
}
