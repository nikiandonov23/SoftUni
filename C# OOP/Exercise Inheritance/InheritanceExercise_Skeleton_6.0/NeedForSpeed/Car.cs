﻿namespace NeedForSpeed;

public class Car:Vehicle
{
    public override double FuelConsumption => 3;


    public Car(int horsePower, double fuel) : base(horsePower, fuel)
    {
    }
}