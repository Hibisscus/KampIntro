using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {


        static void Main(string[] args)
        {



            List<string> names1 = new List<string> { "Can", "Güray", "Sezer", "Ben" };

            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            names1.Add("YineBen");
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[4]);
        }

    }
}
