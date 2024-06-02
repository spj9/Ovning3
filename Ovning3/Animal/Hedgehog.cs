using System;

class Hedgehog(string name, int age, double weight, int spines) : Animal(name, age, weight)
{
    public int Spines { get; set; } = spines;

    public override void DoSound()
    {
        System.Console.WriteLine("The hedgehog is hissing");
    }

    public override string Stats()
    {
        return base.Stats() + $"spines: {Spines}";
    }
}
