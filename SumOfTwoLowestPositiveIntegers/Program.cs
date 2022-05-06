using System;

namespace sumFoTwoLowestPositiveIntegers
{
     class Program
    { 
        public static void Main(string[] args)
        {
            double[] numArray = {2, 12,2, 6, 1.3, 5, 120, 123, 11, 11234, 7878};
            Console.WriteLine(CalcMethod(numArray));
            Console.ReadLine();
        }

        public static string CalcMethod(double[] numbers)
        {
            //sumTwoSmallestNumbers from an array
            //define variables
            string result = " ";
            bool areGood = false;

        
            //sort the array
            Array.Sort(numbers);
        
            //check if array has floats
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] % 1 == 0){
                    areGood = true;
                }else areGood = false;
            }
        
            //calculate tow last number if all int
            if(areGood){
                result = Convert.ToString(numbers[0] + " , " + numbers[1]);
            }else if(areGood == false){
                result = null;
            }
            //return
            return result;
        }
    }
    
}
