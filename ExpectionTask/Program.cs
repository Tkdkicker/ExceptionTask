using System;

namespace ExpectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3000;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divison of " + num2 + " by 0");
            }
        }
    }
}
