using System;
using System.Collections.Generic;
using System.Text;

namespace MissionNetCoreCSharp01
{
    public class Closure
    {
        public Closure()
        {
            Console.WriteLine("Closure");
        }

        public void ClosureExample() 
        {
            Action action = CreateAction();
            action();//counter=1
            action();//counter=2
        }

        //A closure is a block of code which can be executed at a later time, but which maintains 
        //the environment in which it was first created.
        private static Action CreateAction()
        {
            int counter = 0;
            return delegate
            {
                counter++;
                Console.WriteLine($"counter={counter}");
            };
        }
    }
}
