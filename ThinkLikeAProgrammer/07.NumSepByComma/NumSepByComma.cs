using System;

class NumSepByComma
{
    static void Main(string[] args)
    {
        char digit;
        do
        {
            digit = (char)Console.Read();
            int number = (digit - '0');
            digit = (char)Console.Read();
            while (digit != 13 && digit != ',')
            {
                number = number * 10 + (digit - '0');
                digit = (char)Console.Read();
            }
            Console.WriteLine("Number entered: {0}", number);
        } while (digit != 13);
    }
}

