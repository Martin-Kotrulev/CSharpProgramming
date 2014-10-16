using System;
//Write a program that reads a character from the user representing a digit, 0 through
//9. Convert the character to the equivalent integer in the range 0–9, and then output
//the integer to demonstrate the result.
class ConvertCharDigitToInt
{
    static void Main()
    {
        char digit;
        int oddL = 0;
        digit = (char)(Console.Read());
        int sum = digit - '0';

        Console.WriteLine(sum);
    }
}

