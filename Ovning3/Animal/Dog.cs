using System;

class Dog(string name, int age, double weight, double ExerciseTime) : Animal(name, age, weight)
{
    public double ExerciseTime { get; set; } = ExerciseTime;

    public override void DoSound()
    {
        System.Console.WriteLine("The dog barks");
    }

    public override string Stats()
    {
        return base.Stats() + $"Exercise time: {ExerciseTime}";
    }

    public string Run()
    {
        return "The dog is running!";
    }
}
