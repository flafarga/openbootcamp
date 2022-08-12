using System;

namespace Sesion02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Exercise 1---");
            Exercise01 ex1 = new Exercise01();

            ex1.getData();
            ex1.showData();

            Console.WriteLine("---Exercise 2---");
            Exercise02 ex2 = new Exercise02();

            ex2.printData();

            Console.WriteLine("---Exercise 3---");
        }
    }
}