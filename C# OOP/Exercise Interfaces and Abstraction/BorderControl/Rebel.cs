﻿namespace BorderControl;

public class Rebel : INamable, IBuyer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }
    public int Food { get; set; } = 0;



    public void BuyFood()
    {
        this.Food += 5;
    }

    public Rebel(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }
}