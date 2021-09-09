// C# program program to
// check for even or odd
using System;

class GFG
{
    // Returns true if n is even, else odd
    public static bool isEven(int n)
    {
        return (n % 2 == 0);
    }

    // Driver code
    public static void Main()
    {
        int n = 102;
        if (isEven(n) == true)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}
