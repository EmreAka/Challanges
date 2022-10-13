using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions;

internal class MigratoryBirds
{
    private static List<int> arr = new List<int>() 
        { 1, 2, 4, 3, 5, 4, 3, 2, 1, 3, 4,5,5,5 };

    public static int Run()
    {
        Dictionary<int, int> results = new Dictionary<int, int>()
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
        };

        for (var i = 1; i <= 5; i++)
        {
            var result = arr.Count(x => x == i);
            results[i] = result;
        }

        var resultValue = results.Values.Max();
        var resultKey = results.FirstOrDefault(x => x.Value == resultValue).Key;

        return resultKey;
    }
}
