using System;

namespace Session01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercise01 ex1 = new Exercise01();
            Exercise02 ex2 = new Exercise02();

            Console.WriteLine("--Exercise 1--");
            Console.WriteLine("Introduce your name");
            ex1.PrintName();
            Console.WriteLine("--Exercise 2--");
            ex2.GetTime();
        }
    }
}