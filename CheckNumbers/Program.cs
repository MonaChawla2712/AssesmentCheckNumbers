using System;
using System.Text;

namespace CheckNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number = ");
            string val = Console.ReadLine();
            CheckNumbers(Convert.ToInt64(val));
        }

        public static void CheckNumbers(long num)
        {
            StringBuilder msg = new StringBuilder();
            bool flag = true;
            if (num % 3 == 0)
            {
                msg.Append("Fizz");
                flag = false;
            }
            if(num % 5 == 0)
            {
                msg.Append("Buzz");
                flag = false;
            }
            if(flag && (num % 3 !=0 || num % 5 != 0))
            {
                msg.Clear();
                msg.Append(num);
            }
            Console.WriteLine(msg.ToString()); 
        }
    }
}
