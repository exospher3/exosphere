using System;

namespace findArmStrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0; i < 999; i++ )
            {
                double[] nums = new double[i.ToString().Length];
                string numbersInLetter = i.ToString();

                for (int x = 0; x < nums.Length; x++ )
                {
                    nums[x] = numbersInLetter[x] - 48;
                }
                double total = 0;
                for (int x = 0; x < nums.Length; x++)
                {
                    total += Math.Pow(nums[x], 3);
                }

                double finalNum = Convert.ToDouble(numbersInLetter);

                if(finalNum== total)
                {
                    Console.WriteLine(total + " Is an ArmStrong Number");
                }


            }
        }
    }
}
