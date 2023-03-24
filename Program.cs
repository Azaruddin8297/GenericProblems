namespace GenericProb
{
    public class Genric
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String Value");
            Console.WriteLine("Enter the FirstNumber");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the SecondNumber");
            string s2 = Console.ReadLine();
            Console.WriteLine("Enter the ThirdNumber");
            string s3 = Console.ReadLine();
            string val = Refactoe<string>.FindMax(s1,s2,s3);
            Console.WriteLine("Highest String is" + val);
            Console.WriteLine("*******************************");
            Console.WriteLine("Enter the Integer Values");
            Console.WriteLine("Enter the FirstNumber");
            int num1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int val1 = Refactoe<int>.FindMax(num1, num2, num3);
            Console.WriteLine("Highest Integer is" + val1);
            Console.WriteLine("*******************************");
            Console.WriteLine("Enter the Double Values");
            Console.WriteLine("Enter the FirstNumber");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the SecondNumber");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the ThirdNumber");
            double d3 = Convert.ToDouble(Console.ReadLine());
            double val2 = Refactoe<double>.FindMax(d1,d2,d3);
            Console.WriteLine("Highest String is" + val2);
            Console.WriteLine("*******************************");


        }
    }
}
