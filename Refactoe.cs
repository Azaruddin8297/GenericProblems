using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProb
{
    public class Refactoe
    {
        public static void FindMax<T>(T firstvalue, T secondvalue, T thirdvalue) where T : IComparable
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
                Console.WriteLine(firstvalue + " is maximum");
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
                Console.WriteLine(secondvalue + " is maximum");
            if (thirdvalue.CompareTo(secondvalue) > 0 && thirdvalue.CompareTo(firstvalue) > 0)
                Console.WriteLine(thirdvalue + " is maximum");
        }
    }
}
