using System;
using System.Collections.Generic;
using System.Text;

namespace ListFilteringKata
{
    public abstract class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> results = new List<int>();

            foreach(var item in listOfItems)
            {
                if(item is int)
                {
                    results.Add((int)item);
                }
            }

            return results;
        }
    }
}
