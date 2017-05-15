using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        
        foreach (var i in BigSum(n,arr))
        {
            Console.Write(i);
        }
        Console.Read();
    }

    private static int[] BigSum(int n,int[] r)
    {
        if (n == 1)
            return ConvertIntToString(r[0]);

        //sort an array
        r = r.OrderByDescending(i => i).ToArray();
        //convert to int array
        var list = new List<int[]>();
        for (int i = 0; i < n; i++)
        {
            list.Add(ConvertIntToString(r[i]));
        }
        return SumIntegers(list);
    }

    private static int[] SumIntegers(List<int[]> list)
    {
        var res = new Stack<int>();
        var temp = 0;
        for (int i = 0; i < list[0].Length; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].Length > i)
                {
                    temp += list[j][i];
                }
            }
            if (i != list[0].Length-1)
            {
                res.Push(temp % 10);
                temp = temp / 10;
            }
        }
        res.Push(temp);
        return res.ToArray();
    }


    private static int[] ConvertIntToString(int val)
    {
        var list = new List<int>();
        while (val > 0)
        {
            list.Add(val%10);
            val /= 10;
        }
        return list.ToArray();
    }

}