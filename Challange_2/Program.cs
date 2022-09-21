Console.WriteLine("Enter a sentence: ");
string value = Console.ReadLine()!;
string[] words = value.Split(' ');

Dictionary<string, string> dictionary = new Dictionary<string, string>();

for (int i = 0; i < words.Length; i++)
{
    for (int j = 0; j < words.Length; j++)
    {
        if (i != j)
        {
            if (words[j].Contains(words[i].ToLower()) && !words[i].ToLower().Equals(words[j].ToLower()))
            {
                try
                {
                    dictionary.Add(words[i], words[j]);
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
        }
    }

}

foreach (KeyValuePair<string, string> word in dictionary)
{
    Console.WriteLine($"The word {word.Key} appears in the word {word.Value}");
}