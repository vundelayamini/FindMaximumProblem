using System;

namespace MaximumUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Find Maximum float Number :");
            FindMaximumNum find = new FindMaximumNum();
           Console.WriteLine(find.MaximumFloatNumber(10.3f, 20.4f, 30.5f));
        }
}
}
