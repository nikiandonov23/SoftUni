using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];

            Console.WriteLine("input number");
            string inputNumber = Console.ReadLine();
           
            while (inputNumber!="end")
            {
                
                
                int inputAsNumber = int.Parse(inputNumber);
                Console.WriteLine("number index");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine("input number");
                inputNumber = Console.ReadLine();

                masiv[index] = inputAsNumber;


                if (inputNumber == "end")
                {
                    Console.WriteLine(string.Join("==",masiv));
                    break;
                }
               
            }

           
            
        }
    }
}