using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkApp_6503Gin
{
    class Filter
    {
        public List<Creature> SortAZ(List<Creature> cList)
        {
            cList = cList.OrderBy(x => x.CreatureName).ToList();

            return cList;
        }

        public List<Creature> SortZA(List<Creature> cList)
        {
            cList = (from x in cList
                     orderby x.CreatureName descending
                     select x).ToList();

            return cList;
        }

        public List<Creature> Search(List<Creature> cList, string term)
        {
            List<Creature> results = new List<Creature>();

            foreach (Creature c in cList)
            {
                if (c.CreatureName.ToLower().Contains(term.ToLower()))
                {
                    results.Add(c);
                }
            }
            return results;
        }
    }
}
