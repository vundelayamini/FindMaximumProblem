using System;

namespace MaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Find Maximum String: ");
            FindMaximumNum find = new FindMaximumNum();
           Console.WriteLine(find.MaximumStrigNumber("Apple", "Banana", "Peach"));
        }
}
}
