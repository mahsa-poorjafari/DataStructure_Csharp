using System;
using System.Collections.Generic;

namespace DataStructure_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Ordering method:");
            Console.WriteLine("1:Bubble, 2:Selection, 3:Quick");
            string sortType = Console.ReadLine();
            Sorting sorting = new Sorting();
            switch (sortType)
            {
                case "1":
                    Console.WriteLine("Arr[5,1,4,2,8]");
                    IList<int> Arr = new List<int> { 5, 1, 4, 2, 8 };                    
                    IList<int> sortedArr = sorting.BubbleSort(Arr);
                    Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(sortedArr));
                    Console.ReadLine();
                    break;
                case "2":
                    int[] arr2 = new int[] { 10, 30, 17, 12, 1, 21, 15 };
                    foreach (var a in arr2)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine();
                    int[] selectionArr2 = sorting.SelectionSort(arr2);
                    foreach (var item in selectionArr2)
                    {
                        Console.Write(item + " " );
                    }
                    
                    Console.ReadLine();
                    break;

                case "3":
                    int[] arr3 = new int[] { 2, 8, 7, 1, 3, 5, 6, 4 };
                    int low = 0;
                    int high = arr3.Length;
                    foreach (var item in arr3)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine();
                    int[] qArr = sorting.QuickSort(arr3, low, high-1);
                    foreach (var q in qArr)
                    {
                        Console.Write(q.ToString() + " ");
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
            
        }
    }
}
