using System;
namespace EmployeeData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Nikolay";
            string lastName = "Andonov";
            byte age = 28;
            char sex = 'M';
            ulong PersonalID = 8306112507;
            uint UniqueEmployeeNumber = 27569999;
            Console.WriteLine("Firstname {0}",firstName);
            Console.WriteLine("Lastname {0}",lastName);
            Console.WriteLine("you age {0}",age);
            Console.WriteLine("Your sex {0}",sex);
            Console.WriteLine("PersonalID {0}",PersonalID);
            Console.WriteLine("Your Employee number {0}",UniqueEmployeeNumber);
            Console.ReadLine();


        }
    }
}
