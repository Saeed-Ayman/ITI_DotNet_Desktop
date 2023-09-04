/*
 * - Pass by (reference, value).
 * - (in, out) Keywords.
 * - Default value's and named parameter's.
 * - (unary, binary) Operator's overriding and overloading.
 * - access modifier.
 */

namespace Day7;

class Main
{
    public static void ComplexIndex()
    {
        Complex c1 = new(5, 8);
        Complex c2 = new(4, 2);

        Console.WriteLine($"c1 = {c1}, c2 = {c2}");
        Console.WriteLine($"c1 + c2 = {c1 + c2}");
        Console.WriteLine($"c1 - c2 = {c1 - c2}");
        Console.WriteLine($"c1 > c2 = {c1 > c2}");
        Console.WriteLine($"c1 < c2 = {c1 < c2}");
        Console.WriteLine($"c1 == c2 = {c1 == c2}");
        Console.WriteLine($"c1 != c2 = {c1 != c2}");
    }

    public static void StudentIndex()
    {
        Student s1 = new(1, "Saeed", 21);
        Student s2 = new(2, "Ahmed", 19);

        Console.WriteLine($"s1 = {s1}");
        Console.WriteLine($"s2 = {s2}");
        Console.WriteLine($"s1 > s2 = {s1 > s2}");
        Console.WriteLine($"s1 < s2 = {s1 < s2}");
        Console.WriteLine($"s1 == s2 = {s1 == s2}");
        Console.WriteLine($"s1 != s2 = {s1 != s2}");
        Console.WriteLine($"s1 to int = {(int)s1}");
        Console.WriteLine($"s1 to string = {(string)s2}");
    }
}
