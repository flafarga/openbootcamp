using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    public class Exercise03
    {
        // Un número es mayor o igual a 18
        public bool GreaterOrEqualThanEighteen(int num)
        {
            return num >= 18 ? true : false;
        }

        // Un char es ‘a’
        public bool charIsA(char c)
        {
            return 'a'.CompareTo(c) == 0;
        }

        // Se cumplen dos conciones a la vez(ambas verdaderas)
        public bool twoConditions(bool a, bool b)
        {
            return a && b;
        }

        // Se cumple una de dos condiciones a la vez(una true y otra false)
        public bool oneCondition(bool a, bool b)
        {
            return a || b;
        }
    }
}
