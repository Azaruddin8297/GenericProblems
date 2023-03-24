namespace GenericProb
{
    public class Genric
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter the FirstNumber");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the SecondNumber");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the ThirdNumber");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int val = IntMax.MaxNumber(num1,num2, num3);
            //System.Console.WriteLine("Heights Number is " + val);
            //Console.WriteLine("Enter the FirstNumber");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the SecondNumber");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter the ThirdNumber");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //double val = DoubleMax.MaxNumber(num1, num2, num3);
            //System.Console.WriteLine("Heights Number is " + val);
            Console.WriteLine("Enter the FirstNumber");
            string num1 =Console.ReadLine();
            Console.WriteLine("Enter the SecondNumber");
            string num2 = Console.ReadLine();
            Console.WriteLine("Enter the ThirdNumber");
            string num3 = Console.ReadLine();

            string val = StringMax.MaxNumber(num1, num2, num3);
            System.Console.WriteLine("Heights Number is " + val);
        }
    }
}
