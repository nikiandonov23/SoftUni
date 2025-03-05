using test.Contracts;

namespace test.Models;

public class Warewolf:IHero
{
    public void eat()
    {
        Console.WriteLine($"I EAT MEATT");
    }

    public void Specialty()
    {
        Console.WriteLine($"BEASTMODE");
    }

    public double Math(double n1, char sign, double n2)
    {
        throw new NotImplementedException();
    }
}