using test.Contracts;

namespace test.Models;

public class Vampire : IHero
{
    public void eat()
    {
        Console.WriteLine($"I DRINK BLOOD....");
    }

    public void Specialty()
    {
        Console.WriteLine($"SHADOWMOVE");
    }

    public double Math(double n1, char sign, double n2)
    {
        
        n1 = double.Parse(Console.ReadLine());
        sign = char.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());

       

        if (sign=='-')
        {
            return n1 - n2;
        }

        else 
        {
            return n1 + n2;
        }

    }
}