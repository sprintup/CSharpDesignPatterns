using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Strategy_Real_World
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms in the form of sorting objects. This allows clients to dynamically change sorting strategies including Quicksort, Shellsort, and Mergesort.\n");
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
            /*
            QuickSorted list
             Anna
             Jimmy
             Samual
             Sandra
             Vivek

            ShellSorted list
             Anna
             Jimmy
             Samual
             Sandra
             Vivek

            MergeSorted list
             Anna
             Jimmy
             Samual
             Sandra
             Vivek             
             */
        }
        abstract class SortStrategy
        {
            public abstract void Sort(List<string> list);
        }

        //The 'ConcreteStrategy' class
        class QuickSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                list.Sort();
                Console.WriteLine("QuickSorted list ");
            }
        }

        class ShellSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                Console.WriteLine("ShellSorted list ");
            }
        }

        class MergeSort : SortStrategy
        {
            public override void Sort(List<string> list)
            {
                Console.WriteLine("MergeSorted list ");
            }
        }

        // The 'Context' class
        class SortedList
        {
            private List<string> _list = new List<string>();
            private SortStrategy _sortstrategy;

            public void SetSortStrategy(SortStrategy sortstrategy)
            {
                this._sortstrategy = sortstrategy;
            }

            public void Add(string name)
            {
                _list.Add(name);
            }

            public void Sort()
            {
                _sortstrategy.Sort(_list);

                foreach (string name in _list)
                {
                    Console.WriteLine(" " + name);
                }
                Console.WriteLine();
            }
        }
    }
}
