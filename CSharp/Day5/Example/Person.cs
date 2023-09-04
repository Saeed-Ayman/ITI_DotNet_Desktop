namespace Day5.Example;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public Person(string name, int age, Gender gender) 
        => (Name, Age, Gender) = (name, age, gender);

    public override string ToString() 
        => $"Name: {Name}, \tAge: {Age}, \tGender: {Gender}";
}
