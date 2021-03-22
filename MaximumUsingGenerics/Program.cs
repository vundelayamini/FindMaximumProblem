using System;

namespace MaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number :");
            FindMaximumNum find = new FindMaximumNum();
            Console.WriteLine(find.MaximumIntegerNumber(10, 20, 30));
        }
    }
}
