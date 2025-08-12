using System;

namespace _03.Elevator_SUS_ZAKRUGLQNE
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());    //17
            double capacity = double.Parse(Console.ReadLine());            //3        

            double courses = Math.Ceiling(numberOfPeople / capacity);
            Console.WriteLine(courses);

        }
    }
}
