using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Pascal pascal = new Pascal();
            Console.WriteLine(pascal.PascalSring(4));
            Console.WriteLine(pascal.PascalSring(10));
            Console.ReadLine();
        }
    }

    class Pascal
    {
        public String PascalSring(int height)
        {
            String output = "";
            for (int row = 0; row <= height; row++)
            {
                output += (AddSpaces(((height - row))));

                for (int collumn = 0; collumn <= row; collumn++)
                {
                    output += PascalNumber(row, collumn);


                    output += AddSpaces(2);
                }

                output += "\r\n";
            }
            return output;
        }

        public long PascalNumber(int row, int collumn)
        {
            long factRow = Factorial(row);
            long factCollumn = Factorial(collumn);
            long factRowMinusCollumn = Factorial(row - collumn);

            return factRow / (factCollumn * factRowMinusCollumn);
        }

        private String AddSpaces(int n)
        {
            String output = "";
            for (int i = 0; i < n; i++)
            {
                output += " ";
            }
            return output;
        }


        private long Factorial(long n)
        {
            long fact = 1;
            if (n < 0)
            {
                return 0;
            }
            for (int c = 1; c <= n; c++)
            {
                fact = fact * c;
            }
            return fact;
        }
    }
}