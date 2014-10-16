using System;
//PROBLEM: READING A NUMBER WITH THREE OR
//FOUR DIGITS
//Write a program to read a number character by character and convert it to an integer,
//using just one char variable and one int variable. The number will have either
//three or four digits.
class ReadNumWith3Or4Digits
{
    static void Main()
    {
        Console.Write("Enter three or four digit number: ");
        char digitCh = (char)Console.Read();
        int number = (digitCh - '0');

        do
        {
            digitCh = (char)Console.Read();
            if (digitCh != 13) number = number * 10 + (digitCh - '0');
            else Console.WriteLine("The number: {0}", number);
        } while (digitCh != 13);
    }
}

