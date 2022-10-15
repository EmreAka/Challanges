using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions;

internal class ClimbingLeaderboard
{
    //100,50,40,20,10
    private static List<int> ranked = new() { 100, 50 };
    private static List<int> player = new() { 5, 25, 50, 100, 120 };

    private static int BinarySearch(List<int> array, int item)
    {
        int left = 0;
        int right = array.Count - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (array[middle] == item)
                return middle;

            if (item > array[middle])
                right = middle - 1;

            else if (item < array[middle])
                left = middle + 1;
        }

        if ((left - right) == 1 || (left - right) == -1)
        {
            Console.WriteLine($"Between: {left} and {right}");
            Console.WriteLine($"{left + 1} RANK");
        }
        return -1;
    }

    public static List<int> Run()
    {
        var rankedCleaned = ranked.Distinct().ToList();
        List<int> results = new List<int>();

        for (int i = 0; i < player.Count; i++)
        {
            int left = 0;
            int right = rankedCleaned.Count - 1;
            bool isAdded = false;
            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (rankedCleaned[middle] == player[i])
                {
                    results.Add(middle + 1);
                    isAdded = true;
                    break;
                }

                if (player[i] > rankedCleaned[middle])
                    right = middle - 1;

                else if (player[i] < rankedCleaned[middle])
                    left = middle + 1;
            }

            if (((left - right) == 1 || (left - right) == -1) && isAdded == false)
            {
                results.Add(left + 1);
            }
        }

        return results;
    }
}
