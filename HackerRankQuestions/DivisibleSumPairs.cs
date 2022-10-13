using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions;

public class DivisibleSumPairs
{
    private static List<int> ar = new() { 8, 10 };
    private static int n = 2;
    private static int k = 2;

    private static int result = 0;

    public static int Run()
    {
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i < j && ((ar[i] + ar[j]) % k) == 0)
                {
                    result += 1;
                }
            }
        }

        return result;
    }
}
