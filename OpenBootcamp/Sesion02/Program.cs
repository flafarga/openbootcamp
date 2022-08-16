using System;

namespace Session02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---Exercise 1---");
            Exercise01 ex1 = new Exercise01();

            //ex1.GetData();
            //ex1.ShowData();

            Console.WriteLine("---Exercise 2---");
            Exercise02 ex2 = new Exercise02();

            //ex2.PrintData();

            Console.WriteLine("---Exercise 3---");
            Exercise03 ex3 = new Exercise03();

            Console.WriteLine(ex3.GreaterOrEqualThanEighteen(15));
            Console.WriteLine(ex3.GreaterOrEqualThanEighteen(20));
            Console.WriteLine(ex3.charIsA('b'));
            Console.WriteLine(ex3.charIsA('a'));
            Console.WriteLine(ex3.twoConditions(true, false));
            Console.WriteLine(ex3.twoConditions(true, true));
            Console.WriteLine(ex3.oneCondition(false, false));
            Console.WriteLine(ex3.oneCondition(true, false));
            Console.WriteLine(ex3.oneCondition(true, true));
        }
    }
}