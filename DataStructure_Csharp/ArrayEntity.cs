using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    class ArrayEntity : ISearch
    {
        public int N { set; get; }
        public int[] Myarray { set; get; }


        public ArrayEntity(int[] array, bool SortFirst)
        {
            Myarray = array;
            N = Myarray.Length;
            if (SortFirst)
            {
                Myarray = BubbleSort(Myarray);
                this.Print();
            }

        }
        public void Print()
        {
            for (int i = 0; i <= N - 1; i++)
            {
                Console.Write(Myarray[i] + ",");
            }
            Console.WriteLine();
        }

        public void ReverseIt()
        {
            this.Print();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                stack.Push(Myarray[i]);
            }
            for (int i = 0; i < N; i++)
            {
                Myarray[i] = stack.Pop();
            }
            Console.Write("After Reverse=> ");
            this.Print();
            Console.ReadLine();
        }

        public int BinarySearch(int x, int low, int high)
        {
            Console.WriteLine("  " + low + " " + high);
            //Console.ReadLine();


            if (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("mid index=> " + mid);
                if (x < Myarray[mid])
                {
                    return BinarySearch(x, low, mid - 1);

                }
                else if (x > Myarray[mid])
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
                        Swap(ref array[j], ref array[j + 1]);
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
            for (int i = 0; i < N - 1; i++)
            {
                m = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (Myarray[j] < Myarray[m])
                    {
                        m = j;
                    }
                }
                Swap(ref Myarray[m], ref Myarray[i]);
            }
        }

        public void InsertionSort()
        {
            int key, j;
            for (int i = 1; i < 2; i++)
            {
                key = Myarray[i];
                j = i - 1;
                this.Print();
                Console.ReadLine();
                while (j >= 0 && Myarray[j] > key)
                {
                    Myarray[j + 1] = Myarray[j];
                    j--;
                }
                Myarray[j + 1] = key;
            }
        }
        public void KMessyArray()
        {
            int k = 2;
            int m;
            for (int i = 0; i < N; i++)
            {
                m = i;
                for (int j = i + 1; j <= i + k && j < N; j++)
                {
                    if (Myarray[j] < Myarray[m])
                        m = j;
                }
                if (m != i)
                {
                    Swap(ref Myarray[m], ref Myarray[i]);
                }

            }
        }
        //Given an array, find the int that appears an odd number of times.

        //There will always be only one integer that appears an odd number of times.
        public int FindOdd()
        {
            this.Print();
            int[] seq = Myarray;            
            int count;
            int oddNumber = -1;
            int n = seq.Length;
            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (seq[j] == seq[i])
                        count++;
                }
                if (count % 2 == 1)
                    oddNumber = seq[i];
            }
            return oddNumber;
        }
        
    }

}


