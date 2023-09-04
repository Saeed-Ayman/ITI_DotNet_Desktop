namespace Day7;

#pragma warning disable CS0660, CS0661 // Type defines operator == or operator != but does not override Object.Equals(object o) and Object.GetHashCode()
struct Complex
#pragma warning restore CS0661, CS0660  // Type defines operator == or operator != but does not override Object.Equals(object o) and Object.GetHashCode() 
{
    private readonly int _real;
    private readonly int _img;

    public Complex(int real = 0, int img = 0) => (_real, _img) = (real, img);

    public static Complex operator +(Complex c1, Complex c2) => new(c1._real + c2._real, c1._img + c2._img);

    public static Complex operator -(Complex c1, Complex c2) => new(c1._real - c2._real, c1._img - c2._img);

    public static bool operator ==(Complex c1, Complex c2) => c1._real == c2._real && c1._img == c2._img;

    public static bool operator !=(Complex c1, Complex c2) => c1._real != c2._real || c1._img != c2._img;

    public static bool operator <(Complex c1, Complex c2) => c1.Abs() < c2.Abs();

    public static bool operator >(Complex c1, Complex c2) => c1.Abs() > c2.Abs();

    public readonly double Abs() => Math.Sqrt(_real * _real + _img * _img);

    public override readonly string ToString() => $"{_real} + {_img}i";
}
