using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankQuestions;

internal class DiagonalDifference
{
    public static List<List<int>> arr = new List<List<int>>() { new() { 11,2,4}, new() { 4,5,6}, new() { 10,8,-12} };
    public static int Run()
    {
        var countLeftToRight = 0;
        var countRightToLeft = 0;

        for (var i = 0; i < arr.Count; i++)
        {
            countLeftToRight += arr[i][i];
        }

        int j = arr.Count - 1;
        for (int i = 0; i < arr.Count; i++)
        {
            countRightToLeft += arr[i][j];
            j = j - 1;
        }

        var result = countLeftToRight - countRightToLeft;

        if (result < 0)
        {
            result *= -1;
        }

        return result;
    }
}
