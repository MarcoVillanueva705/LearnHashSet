using System;
using System.Collections.Generic;

namespace LearnHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();
            myHash.Add("Hi-diddly-ho!");
            myHash.Add("Doh!");
            myHash.Add("Doh!");


            Console.WriteLine(myHash.Count);

            //see if another array contains the same items that another 
            //array has

            //need to create another IEnumerable (collection) to see
            //if there's overlap between arrays
            String[] s = new string[] { "PIZZA" }  ;

            Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
