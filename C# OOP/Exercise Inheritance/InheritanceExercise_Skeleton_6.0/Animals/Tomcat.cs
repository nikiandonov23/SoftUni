﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Animals;

public class Tomcat : Cat
{
    private const string DefaultGender = "Male";

    public Tomcat(string name, int age) : base(name, age, DefaultGender)
    {

    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}