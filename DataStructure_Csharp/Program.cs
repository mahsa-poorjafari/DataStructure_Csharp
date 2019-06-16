using System;
using System.Collections.Generic;

namespace DataStructure_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Ordering method:");
            Console.WriteLine("1:Bubble, 2:Selection, 3:Quick, 4:BinarySearch, 5:Reverse an Array, 6:InsertionSort");
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
                        Console.Write(a + ", ");
                    }
                    Console.WriteLine();
                    ArrayEntity selectionArr = new ArrayEntity(arr2, true);
                    //int[] selectionArr2 = sorting.SelectionSort(arr2);
                    selectionArr.SelectionSort();
                    selectionArr.Print();                 
                    
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

                case "4":
                    int[] thearray = new int[] { 2, 8, 7, 1, 3, 5, 6, 4 };
                    ArrayEntity myarray = new ArrayEntity(thearray, false);
                    int lo = 0;
                    int hi = thearray.Length - 1;
                    int foundedItem = myarray.BinarySearch(3, lo, hi);
                    Console.Write("foundedItemIndex=> ");
                    Console.WriteLine(foundedItem.ToString());
                    
                    break;
                case "5":
                    int[] theArray = new int[] { 2, 8, 7, 1, 3, 5, 6, 4 };
                    ArrayEntity array = new ArrayEntity(theArray, false);
                    array.ReverseIt();
                    break;
                case "6":
                    int[] theInArray = new int[] { 1, 4, 5, 2, 3, 7, 8, 6, 10, 9 };
                    ArrayEntity arrayIn = new ArrayEntity(theInArray, false);
                    arrayIn.InsertionSort();
                    arrayIn.Print();
                    
                    break;
                default:
                    break;
            } // End switch
            Console.ReadLine();

        } // end Main
    }
}
