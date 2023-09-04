namespace Day2;

class Club
{
    private static int ID;

    static Club() => ID = 1;

    public int Id { set; get; }
    public string Name { set; get; }
    private List<Employee> Subscriptions { set; get; }

    public Club(string name)
        => (Id, Name, Subscriptions) = (ID++, name, new());

    public List<Employee> GetSubscriptions() => Subscriptions;

    public void ObserveAddEmployee(object? e, Employee employee)
        => Subscriptions.Add(employee);

    public override string ToString()
        => $"{Id} - {Name}, Subscription Number: {Subscriptions.Count}";
}
