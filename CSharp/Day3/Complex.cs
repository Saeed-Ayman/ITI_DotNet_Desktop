namespace Day3;

public struct ComplexNumber
{
    public int Real { get; set; }

    private int _img;

    public int Img
    {
        readonly get => _img;
        set => _img = value >= 0 ? value : 0;
    }

    public readonly void Print() 
        => Console.WriteLine($"{Real}+{Img}i");
}