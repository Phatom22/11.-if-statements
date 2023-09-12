using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //the test that can be true ir false
            bool isMale = true;
            if(isMale)
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are female");
            }
            //can also test 2 conditions with and 
            bool isTall = true;
            if(isTall && isMale) {

                Console.WriteLine("you are both male and tall");
            }

            else if (isTall && isMale)
            {
                Console.WriteLine("you are not tall but male ");
            }
            else if (isTall && isMale)
            {
                Console.WriteLine("you are neither a man nor tall");
            }
            else
                    {
                        
                Console.WriteLine("you are none");
            }


            Console.ReadLine();
        }
    }
}
