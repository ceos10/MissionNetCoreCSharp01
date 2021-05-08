using System;

namespace MissionNetCoreCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            var conditional = new Conditionals();
            conditional.TernaryConditionalOperator();
            conditional.IfStatement();
            conditional.BitwiseOperator();
            conditional.NullCoalescingOperator();
            conditional.NullCoalescingAssignmentOperator();
            conditional.SwitchExpression();

            Console.WriteLine();

            var loops = new Loops();
            loops.DoStatement();
            loops.ForStatement();
            loops.ForEachStatement();
            loops.WhileStatement();

            Console.WriteLine();

            var collectionsAndDataStructures = new CollectionsAndDataStructures();
            collectionsAndDataStructures.DictionaryCollection();
            collectionsAndDataStructures.GenericListCollection();
            collectionsAndDataStructures.GenericQueueCollection();
            collectionsAndDataStructures.GenericSortedListCollection();
            collectionsAndDataStructures.GenericStackCollection();
            collectionsAndDataStructures.ConcurrentQueueCollection();
            collectionsAndDataStructures.ConcurrentBagCollection();
            collectionsAndDataStructures.HashTableCollection();
            collectionsAndDataStructures.ArrayListCollection();

            Console.WriteLine();

            var closure = new Closure();
            closure.ClosureExample();

            Console.WriteLine();

            var boxingUnboxing = new BoxingUnboxing();
            boxingUnboxing.BoxingUnboxingClassExample();
            boxingUnboxing.BoxingUnboxingStructExample();

            Console.WriteLine();

            var assembly = new Assembly();
            assembly.AssemblyExample();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
