using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace couse_work_web.Sort
{
    class YearSort : IComparer
    {
        public int Compare(string[] o1, string[] o2)
        {
            int a = Convert.ToInt32(o1[1]);
            int b = Convert.ToInt32(o2[1]);

            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return -1;
            }

            return 0;
        }
    }
}
