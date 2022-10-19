namespace HackerRankQuestions;

internal class TheGridSearch
{
    private static List<string> G = new List<string>()
    {
        "7283455864",
        "6731158619",
        "8988242643",
        "3830589324",
        "2229505813",
        "5633845374",
        "6473530293",
        "7053106601",
        "0834282956",
        "4607924137"
    };

    private static List<string> P = new List<string>()
    {
        "9505",
        "3845",
        "3530"
    };

    public static string Run()
    {
        var found = false;
        var beginRow = 0;
        var beginColumn = 0;
        int i = 0;
        var j = 0;
        for (i = 0; i < P.Count; i++)
        {
            j = beginRow + 1;
            for (j = 0; j < G.Count; j++)
            {
                if (G[j].Contains(P[i]))
                {
                    var occuranceIndex = G[j].IndexOf(P[i][0]);
                    var result = G[j].Substring(occuranceIndex, P[i].Length);
                    if (result.Equals(P[i]) && found == false)
                    {
                        beginRow = j;
                        beginColumn = occuranceIndex;
                        found = true;
                        break;
                    }

                    if (found)
                    {

                    }
                }
            }
            if (i == 0 && found == false)
            {
                return "NO";
            }
        }


        return "";
    }
}
