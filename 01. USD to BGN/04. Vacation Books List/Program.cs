using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int obshtostrsnici = int.Parse(Console.ReadLine());
            int stranicinachas = int.Parse(Console.ReadLine());
            int dni = int.Parse(Console.ReadLine());


            int chasovenaden = obshtostrsnici / stranicinachas / dni;
            Console.WriteLine(chasovenaden);
        }
    }
}
