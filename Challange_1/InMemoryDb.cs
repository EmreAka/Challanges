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

	public void CopyAndAdd(Person person)
	{
		Person CoppiedPerson = (Person)Activator.CreateInstance(person.GetType());
		
		var fields = typeof(Person).GetProperties();

		foreach (var field in fields)
		{
			var value = field.GetValue(person);
		}

		Console.WriteLine(CoppiedPerson.ToString());

		this.People.Add(CoppiedPerson);
	}

	public void List()
	{
		foreach (Person person in People) Console.WriteLine(person.ToString());
	}
}
