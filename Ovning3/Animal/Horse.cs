using System;

class Horse(string name, int age, double weight, double maxSpeed) : Animal(name, age, weight)
{
    public double MaxSpeed { get; set; } = maxSpeed;

    public override void DoSound()
    {
        System.Console.WriteLine("The horse neighs");
    }

    public override string Stats()
    {
        return base.Stats() + $"Max Speed: {MaxSpeed}";
    }
}
