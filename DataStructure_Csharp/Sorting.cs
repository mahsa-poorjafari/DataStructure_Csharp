using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    class Sorting
    {
        public void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        public int Partition(int[] a, int l, int h)
        {
            int pivot = a[h];
            int i = l-1;
            for (int j = l; j < h - 1; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    swap(ref a[i], ref a[j]);                    
                }
            }
            swap(ref a[i+1], ref a[h]);
            //foreach (var item in a)
            //{
            //    Console.Write(item.ToString(), " ");
            //}
            //Console.WriteLine();
            return i= i+1;
        }
        public int[] QuickSort(int[] arr3, int l, int h)
        {
            int low = l;
            int high = h;
            int p;

            if (low < high)
            {
                p = Partition(arr3, low, high);
                QuickSort(arr3, low, p-1);
                QuickSort(arr3, p+1, high);
            }
            return arr3;
        }
        public int[] SelectionSort(int[] array)
        {
            int n = array.Length;
            int m, temp;
            for (int i = 0; i < n - 1; i++)
            {
                m = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[m])
                    {
                        m = j;

                    }
                }
                temp = array[m];
                array[m] = array[i];
                array[i] = temp;

            }

            return array;
        }

        public IList<int> BubbleSort(IList<int> array)
        {
            //int i, j = 0;
            bool swapped;
            int temp;
            int n = array.Count;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {                        
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return array;
        }


        public static void execture()
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
            }}
    }


}
