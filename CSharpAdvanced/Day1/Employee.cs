namespace Day1;

class Employee
{
    private static int ID;

    static Employee() => ID = 0;

    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Address { get; set; }

    public Employee(string name, double salary, string address)
        => (Id, Name, Salary, Address) = (++ID, name, salary, address);

    public override string ToString() => $"{Id} - {Name}, {Salary}, {Address}";
}
