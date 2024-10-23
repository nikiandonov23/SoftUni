using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {



            string animalType = "";
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string input2 = Console.ReadLine();

                string[] tockens = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tockens[0];
                int age = int.Parse(tockens[1]);
                string gender = tockens[2];

                Animal animal = null;
                bool isValid = true;

                try
                {
                    if (animalType=="Dog")
                    {
                        animal = new Dog(name, age, gender);
                    }
                    else if (animalType=="Cat")
                    {
                        animal = new Cat(name, age, gender);
                    }
                    else if (animalType== "Frog")
                    {
                        animal = new Frog(name, age, gender);
                    }
                    else if (animalType=="Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (animalType=="Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }

                    isValid = animal is not null;


                }
                catch (ArgumentException e)
                {
                   isValid =false;
                }

                if (isValid)
                {
                    Console.WriteLine(animal);
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }



        }
    }
}
