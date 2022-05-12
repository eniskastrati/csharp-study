using System;

namespace TryCatchThrow_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, result = 0;

            Console.WriteLine("############");
            Console.WriteLine("#   Math   #");
            Console.WriteLine("############\n");
            try
            {

                //input
                Console.Write("Please type in the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type in the first number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                //calculation
                result = num1 / num2;

                //Output
                Console.WriteLine("{0} / {1} = {2}",num1, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();

        }
    }
}