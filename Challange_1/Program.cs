using Challange_1;

void Run()
{
    InMemoryDb inMemoryDb = new() { };
    ObjectCopier objectCopier = new ObjectCopier();

    Person person = new Person() { FullName = "Emre Aka"};


    Person coppiedObject = objectCopier.CopyObject(person);
}

Run();