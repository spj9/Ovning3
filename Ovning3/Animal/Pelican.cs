using System;

class Pelican(string name, int age, double weight, double wingSpan, double beakSize)
    : Bird(name, age, weight, wingSpan)
{
    public double BeakSize { get; set; } = beakSize;

    public override string Stats()
    {
        return base.Stats() + $"Beak size: {BeakSize}";
    }
}