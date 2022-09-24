List<int> s = new() { 1, 2, 1, 3, 2, };
int d = 3;
int m = 2;

int total = 0;

int totalTemp = 0;
for (var i = 0; i < s.Count(); i++)
{
    totalTemp = 0;
    if ((i + m) > s.Count())
        break;

    List<int> tempArray = s.Skip(i).Take(m).ToList();
    for (var j = 0; j < tempArray.Count(); j++)
    {
        totalTemp += tempArray[j];
    };
    if (totalTemp == d)
    {
        total += 1;
    }
};

//return total;
Console.WriteLine(total);