using System;
//PROBLEM: POSITIVE OR NEGATIVE
//Write a program that reads 10 integers from the user. After all the numbers have
//been entered, the user may ask to display the count of positive numbers or the count
//of negative numbers.

class PosOrNeg
{
    static void Main()
    {
        int number;
        int posCnt = 0;
        int negCnt = 0;

        for (int i = 1; i <= 10; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number >= 0) posCnt++;
            else negCnt++; 
        }

        char response;
        Console.Write("Do you want (p)ositive ot (n)egative count: ");
        response = char.Parse(Console.ReadLine());
        if (response == 'p') Console.WriteLine(posCnt);
        else if (response == 'n') Console.WriteLine(negCnt);
    }
}

