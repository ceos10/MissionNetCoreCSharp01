using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MissionNetCoreCSharp01.Models;

namespace MissionNetCoreCSharp01
{
    public class CollectionsAndDataStructures
    {
        public CollectionsAndDataStructures()
        {
            Console.WriteLine("Collections and Data Structures");
        }

        // Print the name of the products included on the productsDictionary
        // Use the dictionary key to get the Product names
        public void DictionaryCollection()
        {
            var productsDictionary = new Dictionary<string, Product>()
            {
                {"1", new Product() { Code = "1", Name = "Keyboard", Price = 24.5f} },
                {"2", new Product() { Code = "2", Name = "Mouse", Price = 14} },
                {"3", new Product() { Code = "3", Name = "Screen", Price = 124.95f} }
            };

            Console.WriteLine("Products:");

            productsDictionary.Keys.ToList().ForEach(
                (key) => 
                {
                    var product = productsDictionary[key];
                    Console.WriteLine($"-{product.Name}");
                }
            );
        }

        // Print the name of the products included on the productsList
        public void GenericListCollection()
        {
            var productsList = new List<Product> {
                new Product() { Code = "1", Name = "Keyboard", Price = 24.5f },
                new Product() { Code = "2", Name = "Mouse", Price = 14 },
                new Product() { Code = "3", Name = "Screen", Price = 124.95f }
            };

            Console.WriteLine("Products:");

            foreach (var product in productsList)
                Console.WriteLine($"-{product.Name}");
            
        }

        // Print the name of the numbers included on the numbersQueue
        public void GenericQueueCollection()
        {
            var numbersQueue = new Queue<string>();
            numbersQueue.Enqueue("one");
            numbersQueue.Enqueue("two");
            numbersQueue.Enqueue("three");
            numbersQueue.Enqueue("four");
            numbersQueue.Enqueue("five");

            Console.WriteLine("Numbers in the queue:");

            foreach (var number in numbersQueue)
                Console.WriteLine($"-{number}");

            Console.WriteLine("umbersQueue.Dequeue()");
            var dequeuedNumber = numbersQueue.Dequeue();
            Console.WriteLine($"number dequeued = {dequeuedNumber}");

            Console.WriteLine("umbersQueue.Clear()");
            numbersQueue.Clear();
            Console.WriteLine($"numbersQueue.Count = {numbersQueue.Count}");
        }

        // Print the name of the numbers included on the numbersSortedList
        public void GenericSortedListCollection()
        {
            var numbersSortedList = new SortedList<int, string>();
            numbersSortedList.Add(3, "Three");
            numbersSortedList.Add(1, "One");
            numbersSortedList.Add(2, "Two");
            numbersSortedList.Add(4, "Four");
            numbersSortedList.Add(5, "Five");

            Console.WriteLine("Numbers in the sorted list:");

            foreach (KeyValuePair<int, string> kvp in numbersSortedList)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        }

        // Print the name of the numbers included on the numbersStack
        public void GenericStackCollection()
        {
            var numbersStack = new Stack<string>();
            numbersStack.Push("one");
            numbersStack.Push("two");
            numbersStack.Push("three");
            numbersStack.Push("four");
            numbersStack.Push("five");

            Console.WriteLine("Numbers in the stack:");

            foreach (string number in numbersStack)
                Console.WriteLine($"-{number}");
            
            Console.WriteLine("numbersStack.Pop()");
            var poppedNumber = numbersStack.Pop();
            Console.WriteLine($"number popped = {poppedNumber}");

            Console.WriteLine("numbersStack.Clear()");
            numbersStack.Clear();
            Console.WriteLine($"numbersStack.Count = {numbersStack.Count}");
        }

        //Enquee the first 10000 numbers in a concurrent queue and dequeue in parallel each of them to get the whole sum
        public void ConcurrentQueueCollection() 
        {
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();

            // Populate the queue.
            for (int i = 0; i < 10000; i++)
            {
                cq.Enqueue(i);
            }

            // Peek at the first element.
            int result;
            if (!cq.TryPeek(out result))
            {
                Console.WriteLine("CQ: TryPeek failed when it should have succeeded");
            }
            else if (result != 0)
            {
                Console.WriteLine($"CQ: Expected TryPeek result of 0, got {result}");
            }

            int outerSum = 0;
            // An action to consume the ConcurrentQueue.
            Action action = () =>
            {
                int localSum = 0;
                int localValue;
                while (cq.TryDequeue(out localValue)) localSum += localValue;
                Interlocked.Add(ref outerSum, localSum);
            };

            // Start 4 concurrent consuming actions.
            Parallel.Invoke(action, action, action, action);

            Console.WriteLine($"outerSum = {outerSum}, should be 49995000");
        }

        //Add the first 500 numbers in a concurrent bag and then take each of them
        public void ConcurrentBagCollection() 
        {
            // Add to ConcurrentBag concurrently
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            List<Task> bagAddTasks = new List<Task>();
            for (int i = 0; i < 500; i++)
            {
                var numberToAdd = i;
                bagAddTasks.Add(Task.Run(() => cb.Add(numberToAdd)));
            }

            // Wait for all tasks to complete
            Task.WaitAll(bagAddTasks.ToArray());

            // Consume the items in the bag
            List<Task> bagConsumeTasks = new List<Task>();
            int itemsInBag = 0;
            while (!cb.IsEmpty)
            {
                bagConsumeTasks.Add(Task.Run(() =>
                {
                    int item;
                    if (cb.TryTake(out item))
                    {
                        Console.WriteLine(item);
                        itemsInBag++;
                    }
                }));
            }
            Task.WaitAll(bagConsumeTasks.ToArray());

            Console.WriteLine($"There were {itemsInBag} items in the bag");

            // Checks the bag for an item
            // The bag should be empty and this should not print anything
            int unexpectedItem;
            if (cb.TryPeek(out unexpectedItem))
                Console.WriteLine("Found an item in the bag when it should be empty");
        }

        public void HashTableCollection()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            numberNames.Add(4, "Four");
            numberNames.Add(5, "Five");

            Console.WriteLine("Numbers in the hash table:");

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
        }

        public void ArrayListCollection()
        {
            ArrayList numberNames = new ArrayList { "One", "Two", "Three", "Four", "Five" };

            Console.WriteLine("Numbers in the array list:");

            foreach (var number in numberNames)
                Console.Write(number + ", ");

            Console.WriteLine();

            Console.WriteLine("Numbers in the array list:");

            for (int i = 0; i < numberNames.Count; i++)
                Console.Write(numberNames[i] + ", ");
        }
    }
}
