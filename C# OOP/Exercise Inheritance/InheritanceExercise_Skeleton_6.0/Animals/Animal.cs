using System;
using System.Security.Principal;
using System.Text;

namespace Animals;

public abstract class Animal
{


    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public abstract string ProduceSound();


    public Animal(string name, int age, string gender)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Animal should not have empty name.", nameof(name));
        if (age < 0) throw new ArgumentException("Animal should not have negative age.", nameof(age));
        if (string.IsNullOrWhiteSpace(gender)) throw new ArgumentException("Animal should not have empty gender.", nameof(gender));

        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public override string ToString()
    {
       StringBuilder result=new StringBuilder();
       result.AppendLine($"{this.GetType().Name}");
       result.AppendLine($"{this.Name} {this.Age} {this.Gender}");
       result.AppendLine(this.ProduceSound());
       return result.ToString().Trim();
    }
}