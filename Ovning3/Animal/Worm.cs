using System;

class Worm(string name, int age, double weight, double length) : Animal(name, age, weight)
{
    public double Length { get; set; } = length;

    public override void DoSound()
    {
        System.Console.WriteLine("The worm makes no sound");
    }

    public override string Stats()
    {
        return base.Stats() + $"Length: {Length}";
    }
}