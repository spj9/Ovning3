using System;

// PersonHandler-klassens syfte är att skapa och hantera Person-objekt.
public class PersonHandler
{
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }

    public void SetWeight(Person pers, int weight)
    {
        pers.Weight = weight;
    }

    public void SetHeight(Person pers, int height)
    {
        pers.Height = height;
    }

    public Person CreatePerson(int age, string fname, string lname, int height, int weight)
    {
        return new Person(fname, lname)
        {
            Age = age,
            Height = height,
            Weight = weight
        };
    }
}
