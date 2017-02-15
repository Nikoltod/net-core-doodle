using System;
using AppleStore;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Apple a = new Apple("red", "round", 12);
            System.Console.WriteLine(a.CreateApple());
        }
    }
}
