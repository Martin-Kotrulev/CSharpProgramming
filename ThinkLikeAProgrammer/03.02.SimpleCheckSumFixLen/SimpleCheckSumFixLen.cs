using System;
//PROBLEM: SIMPLE CHECKSUM VALIDATION,
//FIXED LENGTH
//Write a program that takes an identification number (including its check digit) of
//length six and determines whether the number is valid under a simple formula where
//the values of each digit are summed and the result checked to see whether it is divisible
//by 10. The program must process each character before reading the next one.
class SimpleCheckSumFixLen
{
    static int DoubleDigitValue(int digit)
    {
        int doubledDigit = digit * 2;
        int sum;

        if (doubledDigit >= 10) sum = 1 + doubledDigit % 10;
        else sum = doubledDigit;

        return sum;
    }

    static void Main()
    {
        char digit;
        int checkSum = 0;

        Console.Write("Enter six digit number: ");

        // checking position by position and determine
        // every other position to be doubled
        int pos = 1;
        do
        {
            digit = (char)Console.Read();
            if (pos % 2 == 0) checkSum += digit - '0';
            else checkSum += DoubleDigitValue(digit - '0');
            pos++;
        } while (digit != 10);

        Console.WriteLine("Checksum is {0}", checkSum);

        if (checkSum % 10 == 0)
        {
            Console.WriteLine("Checksum is divisible by 10. Valid!");
        }
        else
        {
            Console.WriteLine("Checksum is not divisible by 10. Invalid!");
        }
    }
}

