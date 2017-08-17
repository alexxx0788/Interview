using System;
using System.Collections.Generic;
using Project.Sort;

namespace Project
{
    class MainApp
    {
        static void Main()
        {
            var arr = new int[] {4, 6, 5, 3, 3, 1};
            var list = new IntegerList(arr);
            list.SetSortStrategy(new QuickSort());
            list.Sort();
            list.Print();

            Console.ReadKey();
        }
    }
}