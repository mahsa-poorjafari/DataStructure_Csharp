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
        
    }
}
