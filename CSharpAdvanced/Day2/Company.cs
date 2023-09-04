namespace Day2;

class Company
{
    private static int ID;

    static Company() => ID = 1;

    public int Id { set; get; }
    public string Name { set; get; }
    private List<Employee> Employees { set; get; }
    public event EventHandler<Employee>? OnAddEmployee;

    public Company(string name)
        => (Id, Name, Employees) = (ID++, name, new());

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
        OnAddEmployee?.Invoke(this, employee);
    }

    public List<Employee> GetEmployees()
        => Employees;

    public override string ToString()
        => $"{Id} - {Name}, Employees Number: {Employees.Count}";
}