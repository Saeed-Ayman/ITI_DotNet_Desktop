namespace Day6;

class TOrF : Question
{
    public TOrF(string body, int mark) : base(body, mark) { }

    public override void Show() => Console.WriteLine($"{Id} - [{Mark}] {Body} [T/F]?");
}
