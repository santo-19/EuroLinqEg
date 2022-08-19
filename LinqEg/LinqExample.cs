using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinqEg
{
    internal class LinqExample
    {
        static void main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(50);
            numbers.Add(23);
            numbers.Add(75);
            numbers.Add(5);
            //Query Syntax
            var result  = (from i in numbers
                           where i > 45
                           select i).ToList();
            Console.WriteLine("Query Syntax for Numbers");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            //Method Syntax
            var resnumbers = numbers.Where(x => x > 45).Select(x => x);
            Console.WriteLine("Method Syntax for Numbers");
            foreach(var item in resnumbers)
            {
                Console.WriteLine(item);
            }
            List<string> fruits = new List<string>();
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add("Grapes");
            fruits.Add("Avacado");
            //Query Syntax
            var result2 = (from i in fruits
                           where i.StartsWith('A')
                           select i).ToList();
            Console.WriteLine("Query Syntax for Fruits");
            foreach(var item in result2)
            {
                Console.WriteLine(item);
            }
            //Method Syntax
            var resfruits = fruits.Where(x => x.StartsWith('A')).Select(x => x);
            Console.WriteLine("Method Syntax for Fruits");
            foreach(var item in resfruits)
            {
                Console.WriteLine(item);
            }                         
        }
    }
}
