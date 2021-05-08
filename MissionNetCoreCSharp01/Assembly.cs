using MissionNetCoreCSharp01.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MissionNetCoreCSharp01
{
    public class Assembly
    {
        public Assembly()
        {
            Console.WriteLine("Assembly");
        }

        //Reference Newtonsoft assembly
        public void AssemblyExample() 
        {
            var product = new Product() { Code = "1", Name = "Keyboard", Price = 24.5f };
            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine($"product: {json}");
        }
    }
}
