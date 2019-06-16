using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    interface ISearch
    {
        int BinarySearch(int x, int low, int high);
        void SelectionSort();
        int N { set; get; }
        int[] Myarray { set; get; }
        
    }
}
