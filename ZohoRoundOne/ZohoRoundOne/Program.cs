using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoRoundOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Input");
            int input = Convert.ToInt32(Console.ReadLine());
            int iCount = 1;
            int lineNum = 1;

            while (iCount <= 20)
            {
                int counter = input;

                for (int tabCount = counter - 1; tabCount > 0; tabCount--)
                    Console.Write("   ");
                while (lineNum % 2 == 1)
                {
                    for (int numCount = 0; numCount < input; numCount++)
                    {
                        Console.Write(iCount);
                        Console.Write("   ");
                        iCount++;
                    }
                    break;
                }
                lineNum++;
                Console.WriteLine();
                while (lineNum % 2 == 0)
                {
                    iCount += input - 1;
                    int temp = iCount;
                    
                    for (int numCount = 0; numCount < input; numCount++)
                    {
                        Console.Write(iCount);
                        Console.Write("   ");
                        iCount--;
                    }
                    iCount = temp + 1;
                    break;
                    
                }
                Console.WriteLine();
                lineNum++;
            }

            Console.ReadKey();

        }
    }
}
