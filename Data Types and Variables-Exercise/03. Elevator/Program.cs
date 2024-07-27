using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());    //17
            int capacity = int.Parse(Console.ReadLine());            //3

            int courses = numberOfPeople % capacity;

            if (courses>0)
            {
                Console.WriteLine(numberOfPeople/capacity+1);
            }
            else
            {
                Console.WriteLine(numberOfPeople/capacity);
            }



        }
    }
}
