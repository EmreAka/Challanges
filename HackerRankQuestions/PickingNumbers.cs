using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions;

internal class PickingNumbers
{
    public static List<int> a = new() { 4, 6, 5, 3, 3, 1 };

    public static int Run()
    {
        var result = 0;
        for (int i = 0; i < a.Count; i++)
        {
            var res = a.Count(x => x == a[i] || x == (a[i] -1));
            var resOne = a.Count(x => x == a[i] || x == (a[i] +1));

            if(res > resOne)
            {
                if (res > result)
                {
                    result = res;
                }
            }
            else
            {
                if (resOne > result)
                {
                    result = resOne;
                }
            }
        }

        return result;
    }
}
