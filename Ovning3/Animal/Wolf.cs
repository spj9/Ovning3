using System;

class Wolf(string name, int age, double weight, int cubs) : Animal(name, age, weight)
{
    public int Cubs { get; set; } = cubs;

    public override void DoSound()
    {
        System.Console.WriteLine("The wolf howls");
    }

    public override string Stats()
    {
        return base.Stats() + $"Cubs: {Cubs}";
    }
}
