using System;

namespace Session02
{
    public class Exercise01
    {
        private string? _name;
        private string? _surname;
        private int? _age;
        private bool? _knowsProgramming;
        private string? _message;

        public void GetData()
        {
            Console.WriteLine("Introduce the name:");
            _name = Console.ReadLine();
            Console.WriteLine("Introduce the surname:");
            _surname = Console.ReadLine();
            Console.WriteLine("Introduce the age:");
            _age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce if the person know how to program: [True/False]");
            _knowsProgramming = Convert.ToBoolean(Console.ReadLine());

            _message = string.Format("Name: {0}\nSurname: {1}\nAge: {2}\nKnows Programming: {3}",
                                    _name, _surname, _age, _knowsProgramming);
        }

        public void ShowData()
        {
            Console.WriteLine(_message);
        }
    }
}
