namespace Day6;

class Mcq : Question
{

    public string[] Chooses { get; set; }

    public Mcq(string body, int mark, string[] chooses) : base(body, mark) => Chooses = chooses;

    public override void Show()
    {
        Console.WriteLine($"{Id} - [{Mark}] {Body}?");

        for (int i = 0; i < Chooses.Length; i++)
        {
            Console.WriteLine($"\t{i + 1} - {Chooses[i]}");
        }
        Console.WriteLine("--------------------------------------");
    }
}
