using System;
/// <summary>
/// PROBLEM: A SIDEWAYS TRIANGLE
// Write a program that uses only two output statements, cout << "#" and cout << "\n",
// to produce a pattern of hash symbols shaped like a sideways triangle:
// #
// ##
// ###
// ####
// ###
// ##
// #
/// </summary>
class SideWaysTriangle
{
    static void Main()
    {
        for (int row = 1; row <= 7; row++)
        {
            for (int hash = 1; hash <= 4 - System.Math.Abs(4 - row); hash++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}

