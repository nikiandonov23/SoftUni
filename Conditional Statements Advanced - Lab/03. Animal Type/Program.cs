using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            String nameOFAnimal = Console.ReadLine();

            switch (nameOFAnimal)
            {
                case "dog":
               
                    Console.WriteLine("mammal");
                   break;
              
               case "crocodile":
               case "tortoise":
               case "snake":
                   Console.WriteLine("reptile");
                   break;
               default:
                   Console.WriteLine("unknown");
                   break;





            }
            
                
        }
    }
}
