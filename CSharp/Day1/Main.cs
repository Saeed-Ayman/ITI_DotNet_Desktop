/*
 * - Value data types(int, float, ... etc)  
 * - Read and write from screen
 * - Convert from datatype to another
 */

namespace Day1;

class Main
{
    public static void Index()
    {
        #region Get info from user
        Console.WriteLine("We need some information from you.");
        Console.WriteLine("==================================");
        Console.Write("Your Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Your name: ");
        string? name = Console.ReadLine();

        Console.Write("Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("---------------------------------");
        #endregion

        // this region not include in tutorial
        #region Redirect and clear console
        Console.WriteLine("redirecting . . .");
        Thread.Sleep(1000);
        Console.Clear();
        #endregion

        #region Show info to user
        Console.WriteLine("User Info");
        Console.WriteLine("==========");
        Console.WriteLine($"Id = {id}\nName = {name}\nAge = {age}");
        Console.WriteLine("---------------------------------");
        #endregion
    }
}
