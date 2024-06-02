using System;

class Wolfman : Wolf, IPerson
{
    public Wolfman(string name, int age, double weight, int cubs)
        : base(name, age, weight, cubs) { }

    public void Talk()
    {
        System.Console.WriteLine($"I have {cubs} cubs.");
    }
}