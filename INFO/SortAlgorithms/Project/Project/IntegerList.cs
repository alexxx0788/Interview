using System;
using System.Collections.Generic;
using Project.Sort;

namespace Project
{
    class IntegerList
    {
        private List<int> _list;
        private SortStrategy _sortstrategy;

        public IntegerList()
        {
            _list = new List<int>();
        }
        public IntegerList(int[] arr)
        {
            _list = new List<int>();
            _list.AddRange(arr);
        }

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(int val)
        {
            _list.Add(val);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);
        }

        public void Print()
        {
            var list = String.Join(",", _list);
            Console.Write(list);
        }
    }
}
