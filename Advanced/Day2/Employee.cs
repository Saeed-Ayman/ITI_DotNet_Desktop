namespace Day2;

class Employee
{
    private static int ID;

    static Employee() => ID = 1;

    public int Id { set; get; }
    public string Name { set; get; }

    public Employee(string name)
        => (Id, Name) = (ID++, name);

    public override string ToString()
        => $"{Id} - {Name}";
}
