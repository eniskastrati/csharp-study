using System;

public static class Program
{
  
    public static int Main(int[] numbers)
    {
        //sumTwoSmallestNumbers from an array
        //define variables
        int result = 0;
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
            result = numbers[0] + numbers[1];
        }else if(areGood == false){
            result = 0;
        }
        //return
        return result;
    }
}