namespace HackerRankQuestions;

internal class MarsExploration
{
    private static string s = "SOSSOT";

    public static int Run()
    {
        string lookFor = "SOS";
        int changes = 0;
        for (var i = 0; i < s.Length; i += 3)
        {
            var message = s.Substring(i, 3);
            if (message.Equals(lookFor))
                continue;
            else
            {
                for (var j = 0; j < 3; j++)
                {
                    if (message[j].Equals(lookFor[j]) == false)
                    {
                        changes += 1;
                    }
                }
            }
        }

        return changes;
    }
}
