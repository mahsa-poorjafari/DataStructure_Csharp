using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    class ArrayEntity : ISearch
    {
        public int N { set; get; }
        public int[] Myarray { set; get; }
        public bool Sorted { private set; get; }
        
        public ArrayEntity(int[] array, bool Sorted) {
            Myarray = array;
            N = Myarray.Length;
            if (!Sorted)
            {
                Myarray = BubbleSort(Myarray);
                this.Print();
            }

        }
        public void Print() {
            for (int i = 0; i <= N-1; i++)
            {
                Console.Write(Myarray[i] + ",");
            }
        }

        public int BinarySearch(int x, int low, int high)
        {            
            Console.WriteLine("  " + low + " " + high);
            //Console.ReadLine();
            
            
            if (low <= high) {
                int mid = (low + high) / 2;
                Console.WriteLine("mid index=> " + mid);
                if (x < Myarray[mid])
                {                   
                    return BinarySearch(x, low, mid-1 );
                    
                }
                else if (x > Myarray[mid] )
                {                    
                    return BinarySearch(x, mid + 1, high);
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
        public int[] BubbleSort(int[] array)
        {
            //int i, j = 0;
            bool swapped;     
            
            for (int i = 0; i < N - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < N - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j] , ref array[j + 1]);
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

        public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }

        public void SelectionSort()
        {
            int m;
            for (int i = 0; i < N-1; i++)
            {
                m = i;
                for (int j = i+1; j < N; j++)
                {
                    if (Myarray[j] < Myarray[m]) {                        
                        m = j;
                    }
                }
            Swap(ref Myarray[m], ref Myarray[i]);
            }
        }

    }
}
