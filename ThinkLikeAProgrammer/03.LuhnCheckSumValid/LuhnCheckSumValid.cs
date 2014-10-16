using System;
//PROBLEM: LUHN CHECKSUM VALIDATION
//The Luhn formula is a widely used system for validating identification numbers. Using
//the original number, double the value of every other digit. Then add the values of the
//individual digits together (if a doubled value now has two digits, add the digits individually).
//The identification number is valid if the sum is divisible by 10.
//Write a program that takes an identification number of arbitrary length and
//determines whether the number is valid under the Luhn formula. The program must
//process each character before reading the next one.
class LuhnCheckSumValid
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
        int oddLCheckSum = 0;
        int evenLCheckSum = 0;

        Console.Write("Enter a number: ");

        int pos = 1;
        do
        {
            digit = (char)Console.Read();
            // based on position keep track if whole number is with even or odd digits
            if (pos % 2 == 0) // for position
            {
                oddLCheckSum += DoubleDigitValue(digit - '0'); // get te int value of a char
                evenLCheckSum += digit - '0';
            }
            else
            {
                evenLCheckSum += DoubleDigitValue(digit - '0');
                oddLCheckSum += digit - '0';
            }
            pos++;
        } while (digit != 10);

        int checksum;
        if ((pos - 1) % 2 == 0) checksum = evenLCheckSum;
        else checksum = oddLCheckSum;

        if (checksum % 10 == 0)
        {
            Console.WriteLine("Checksum is divisible by 10. Valid!");
        }
        else Console.WriteLine("Checksum is not divisible by 10. Invalid!");
    }
}

