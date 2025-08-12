using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //do koq stepen da stigne stepenuvaneto  7
            int num = 1;

            for (int i = 0; i <= n; i += 2)      //uveli4avam stepenta s +2 shtoto iskat 4etni
            {
               
                Console.WriteLine(num);
                num = num * 2 * 2;               //imame num*2*2 zashtoto preska4ame po edna stepen

            }


        }
    }
}
