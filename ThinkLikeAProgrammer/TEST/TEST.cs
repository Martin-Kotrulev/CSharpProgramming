using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class TEST
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            char digit;
            while (true)
            {
                digit = (char)Console.Read();
                Console.Write("{0} ", (int)digit);
            }
        }
    }
}
