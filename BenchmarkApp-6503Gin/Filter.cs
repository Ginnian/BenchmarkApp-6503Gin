using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkApp_6503Gin
{
    //Class used for filtering and ordering the various staff attributes.
    public class Filter
    {
        //Order the list alphabetically in descending order
        public List<Staff> SortAZ(List<Staff> cList)
        {
            cList = cList.OrderBy(x => x.FirstName).ToList();

            return cList;
        }

        //Order the list alphabetically in ascending order
        public List<Staff> SortZA(List<Staff> cList)
        {
            cList = (from x in cList
                     orderby x.FirstName descending
                     select x).ToList();

            return cList;
        }

        //Compare the item in the list with the term captured from the search box. Return the items that correspond with the term.
        public List<Staff> Search(List<Staff> cList, string term)
        {
            List<Staff> results = new List<Staff>();

            foreach (Staff c in cList)
            {
                if (c.FirstName.ToLower().Contains(term.ToLower()))
                {
                    results.Add(c);
                }
            }
            return results;
        }
    }
}
