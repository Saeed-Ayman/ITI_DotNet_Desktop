namespace Day6;

abstract class Question
{
    public static int ID;
    public int Id { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }

    static Question() => ID = 0;

    public Question(string body, int mark) => (Id, Body, Mark) = (++ID, body, mark);

    public abstract void Show();
}
