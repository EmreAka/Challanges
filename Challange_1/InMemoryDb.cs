using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1;

public class InMemoryDb
{
    private List<Person> People = new(){ };

	public InMemoryDb()
	{

	}

	public void Add(Person person)
	{
		this.People.Add(person);
		Console.WriteLine("Added to the list.");
	}

	public void List()
	{
		foreach (Person person in People) Console.WriteLine(person.ToString());
	}
}
