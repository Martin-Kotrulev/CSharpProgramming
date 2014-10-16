using System;
/// <summary>
/// Write a program that uses only two output statements, cout << "#" and cout << "\n",
/// to produce a pattern of hash symbols shaped like half of a perfect 5 x 5 square (or a
/// right triangle):
/// #####
/// ####
/// ###
/// ##
/// #
/// </summary>

class HalfOfASquare
{
    static void Main()
    {
        for (int row = 1; row <= 5; row++)
        {
            for (int hashNum = 1; hashNum <= 6 - row; hashNum++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

