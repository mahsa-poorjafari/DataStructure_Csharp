using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Csharp
{
    class ListEntity
    {

        //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
        // Example       ListFilterer.GetIntegersFromList(new List<object>(){1, 2, "a", "b"}) => {1, 2}
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //this.Print((IEnumerable<int>) listOfItems);
            List<int> filteredList = new List<int> { };
            foreach (var item in listOfItems)
            {
                var itemType = item.GetType();
                //Console.Write(itemType.ToString());
                if (itemType.ToString() == "System.Int32")
                {
                    filteredList.Add((int)item);
                }
            }
            return filteredList;
        }
        public void Print(IEnumerable<int> list) {
            Console.Write("{");
            foreach (var item in list)
            {

                Console.Write(item.ToString() + ",");
            }
            Console.Write("}");
        }

    }
}
