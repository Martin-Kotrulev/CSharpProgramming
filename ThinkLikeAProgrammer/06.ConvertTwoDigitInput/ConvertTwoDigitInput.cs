using System;

class ConvertTwoDigitInput
{
    static void Main()
    {
        Console.Write("Enter two digit number: ");
        char digitCh = (char)Console.Read();
        int overallNum = (digitCh - 0) * 10;
        digitCh = (char)Console.Read();
        overallNum = (digitCh - 0) * 10;
        Console.WriteLine("Your number is: {0}", overallNum);
    }
}

