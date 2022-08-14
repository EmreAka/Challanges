namespace Challange_1;

public class Person
{
    public string? FullName { get; set; }
    public List<Person>? Friends { get; set; }

    public Person()
    {

    }

    public Person(string? fullName, List<Person>? friends)
    {
        FullName = fullName;
        Friends = friends;
    }

    public override string ToString()
    {
        if (Friends != null)
        {
            var friends = "";
            foreach (var friend in Friends)
            {
                friends += $" {friend.FullName}";
            }

            return $"Name: {FullName}, Friends:{friends}";
        }

        return $"Name: {FullName}, Friends: No friends";
    }
}
