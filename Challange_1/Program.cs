using Challange_1;

void Run()
{
    InMemoryDb inMemoryDb = new() { };
    ObjectCopier objectCopier = new ObjectCopier();

    Person person = new Person() { FullName = "Emre Aka" };
    Person person1 = new Person() { FullName = "Berkan Fıçıcı", Friends = new List<Person> { person } };

    inMemoryDb.Add(person);
    inMemoryDb.Add(person1);

    objectCopier.CopyObject(person);

}

Run();