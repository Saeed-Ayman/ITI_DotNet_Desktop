namespace Day4;

class Subject
{
    readonly int Id;
    readonly string Name;
    readonly int Duration;

    public Subject(int id, string name, int duration)
        => (Id, Name, Duration) = (id, name, duration);

    public string Print() 
        => $"id: {Id},\t\t name: {Name},\t\t duration: {Duration}";
}