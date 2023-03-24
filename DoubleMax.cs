using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProb
{
    public class DoubleMax
    {
        public static double MaxNumber(double FirstNumber, double SecondNumber, double ThirdNumber)
        {
            {
                if (FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) > 0 ||
                    FirstNumber.CompareTo(SecondNumber) >= 0 && FirstNumber.CompareTo(ThirdNumber) > 0 ||
                    FirstNumber.CompareTo(SecondNumber) > 0 && FirstNumber.CompareTo(ThirdNumber) >= 0)
                {
                    return FirstNumber;
                }
                if (SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) > 0 ||
                    SecondNumber.CompareTo(FirstNumber) >= 0 && SecondNumber.CompareTo(ThirdNumber) > 0 ||
                    SecondNumber.CompareTo(FirstNumber) > 0 && SecondNumber.CompareTo(ThirdNumber) >= 0)
                {
                    return SecondNumber;
                }
                if (ThirdNumber.CompareTo(SecondNumber) > 0 && ThirdNumber.CompareTo(FirstNumber) > 0 ||
                    ThirdNumber.CompareTo(SecondNumber) >= 0 && ThirdNumber.CompareTo(FirstNumber) > 0 ||
                    ThirdNumber.CompareTo(SecondNumber) > 0 && ThirdNumber.CompareTo(FirstNumber) >= 0)
                {
                    return ThirdNumber;
                }
                return FirstNumber;
            }
        }
    }
}
