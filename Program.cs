using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterAlgorithm
{
    //Burak bayram
    class Program
    {
        static void Main(string[] args)
        {
            int cash = Convert.ToInt32(Console.ReadLine());
            int b10 = 0; int b5 = 0; int b2 = 0;

            if (cash == 1 || cash == 3)
                Console.WriteLine("Para üstü verilemiyor!");
            else
            {
                b10 = cash / 10;
                int cashAfter10 = cash - (b10 * 10);
                b5 = cashAfter10 / 5;
                int cashAfter5 = cashAfter10 - (b5 * 5);
                b2 = cashAfter5 / 2;

                if (b10 * 10 + b5 * 5 + b2 * 2 == cash)
                    Console.WriteLine("10'luk: " + b10 + "\n5'lik: " + b5 + "\n2'lik: " + b2);
                else
                {
                    b10 = 0; b5 = 0; b2 = 0;
                    while (cash >= 10)
                    {
                        if (cash % 10 == 1 || cash % 10 == 3)
                        {
                            cash = cash - 5;
                            b5++;
                        }
                        else
                        {
                            b10 = cash / 10; cash = cash - (b10 * 10);
                        }
                    }
                    b2 = cash / 2;
                    Console.WriteLine("10'luk: " + b10 + "\n5'lik: " + b5 + "\n2'lik: " + b2);
                }
            }
            Console.Read();
        }
    }
}