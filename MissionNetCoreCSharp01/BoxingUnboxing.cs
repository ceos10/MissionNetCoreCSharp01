using System;
using MissionNetCoreCSharp01.Models;
using MissionNetCoreCSharp01.Structs;

namespace MissionNetCoreCSharp01
{
    public class BoxingUnboxing
    {
        public BoxingUnboxing()
        {
            Console.WriteLine("Boxing and Unboxing");
        }

        public void BoxingUnboxingClassExample() 
        {
            var product = new Product() { Code = "1", Name = "Keyboard", Price = 24.5f };

            //Boxing product
            object productObject = product;

            //Changing the price of product
            product.Price = 20f;

            Console.WriteLine($"The value-type price value = {product.Price}");
            //Unboxing productObject to print the price value
            Console.WriteLine($"The object-type price value = {((Product)productObject).Price}");
        }

        public void BoxingUnboxingStructExample()
        {
            Point p = new Point(10, 10);

            //Boxing p
            object box = p;
            
            //Changing x of p
            p.x = 20;

            Console.WriteLine($"The value-type x value = {p.x}");
            //Unboxing p to print the x value
            Console.WriteLine($"The object-type x value = {((Point)box).x}");
        }
    }
}
