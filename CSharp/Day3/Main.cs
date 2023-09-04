/*
 * - for each
 * - struct, class, enum, delegate, interface and record
 */

namespace Day3;

class Main
{
    public static void Index()
    {
        #region Get info from user
        Console.WriteLine("-------------------------------------------");

        Console.Write("Enter number of numbers to stored them: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ComplexNumber[] numbers = new ComplexNumber[n];

        Console.WriteLine("-------------------------------------------");

        Console.WriteLine("Enter Complex Number:");
        Console.WriteLine("=====================");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Complex {i + 1}");
            Console.WriteLine("=========");

            Console.Write("Real: ");
            numbers[i].Real = Convert.ToInt32(Console.ReadLine());

            Console.Write("Img: ");
            numbers[i].Img = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
        }
        #endregion

        #region Print info to user
        Console.WriteLine("Complex numbers:");
        Console.WriteLine("=====================");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Number{i + 1} = ");
            numbers[i].Print();
        }
        Console.WriteLine("-------------------------------------------");
        #endregion
    }
}