namespace Day8;

class Subject
{
    private static int ID;
    private readonly int _id;
    private readonly string _name;
    private readonly int _duration;

    static Subject() => ID = 0;

    public Subject(string name, int duration) => (_id, _name, _duration) = (++ID, name, duration);

    public override string ToString() => $"{_id}-{_name}, {_duration} hours.";
}
