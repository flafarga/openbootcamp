using System;

namespace Sesion01
{
    public class Exercise02
    {
        public void GetTime()
        {
            string time = DateTime.Now.ToShortTimeString();
            Console.WriteLine(time);
        }
    }
}
