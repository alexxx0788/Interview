using System;
using System.Collections.Generic;

namespace Project.Sort
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<int> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
