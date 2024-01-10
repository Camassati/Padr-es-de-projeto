using InteraitorPattern.C_;

var persons = new Aggregate<Person>();
persons[0] = new Person("John",30);
persons[1] = new Person("Gustavo", 22);
persons[2] = new Person("Batata", 23);

var iteraitor = persons.Iterator;
while (iteraitor.IsLeft())
{
    Console.WriteLine(iteraitor.Current);
    iteraitor.Next();
}
