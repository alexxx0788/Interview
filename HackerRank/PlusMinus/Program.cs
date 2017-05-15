using System;
using System.Collections.Generic;

class Solution
{

    static void Main(String[] args)
    {
       /* int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);*/
        
        foreach (var plusMinus in PlusMinus(6, new int[] {-6,4,0,2,1,-3}))
        {
            Console.WriteLine(plusMinus);
        }
        Console.Read();
    }

    private static float[] PlusMinus(int n, int[] arr)
    {
        var result = new List<float>();
        var pos = 0;
        var neg = 0;
        var zero = 0;
        foreach (int i in arr)
        {
            if (i == 0)
            {
                zero++;
            }
            else
            {
                var temp = i > 0 ? pos++ : neg++;
            }
        }
        result.Add((float)pos/n);
        result.Add((float)neg / n);
        result.Add((float)zero / n);
        return result.ToArray();
    }
}