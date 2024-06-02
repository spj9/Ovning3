using System;

class Swan(string name, int age, double weight, double wingSpan, string color)
    : Bird(name, age, weight, wingSpan)
{
    public int Color { get; set; } = color;

    public override string Stats()
    {
        return base.Stats() + $"Color: {Color}";
    }
}