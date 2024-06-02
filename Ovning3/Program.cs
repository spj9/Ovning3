
//3.1 Inkapsling
class Program
{
    static void Main(string[] args)
    {
        var personHandler = new PersonHandler();
        Person person1;
        Person person2;
        Person person3;
        try
        {
            person1 = personHandler.CreatePerson(20, "Anders", "Andersson", 181, 85);
            person2 = personHandler.CreatePerson(30, "Zlatan", "Ibrahimovic", 198, 90);
            person3 = personHandler.CreatePerson(40, "Greta", "Garbo", 159, 55);
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }

    }
}

//3.2 Polymorfism
var userErrorList = new List<UserError>();
    userErrorList.AddRange([new NumericInputError(), new TextInputError()]);
    userErrorList.ForEach(error => Console.WriteLine(error.Message));


//3.3 Arv
// (13) Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
//      bör vi lägga det attributet i klassen Bird, eftersom alla klasser av typen fågelart ärver från denna.
//
// (14) Om alla djur behöver ett nytt attribut bör vi lägga det i klassen Animal.


//3.4 Mer polymorfism
var animals = new List<Animal>();
animals.AddRange(
    [   new Pelican("Peter", 3, 1.8, 1.5, 0.4),
        new Wolf("Balder", 5, 20, 2),
        new Worm("Wagner", 2, 0.1, 0.5),
        new Wolfman("Wolverine", 30, 75, 8),
        new Dog("Fido", 5, 10.5, 30),
    ]
);

animals.ForEach(a =>
    {
        Console.WriteLine(a.GetType().Name);
        a.DoSound();
        if (ani is IPerson)
        { (a as IPerson).Talk(); }
    }
);

var dogs = new List<Dog>();

// (9)  Det går inte att lägga till en häst i listan av hundar därför att vi definierat att listan ska innehålla objekt av klassen hund.
//
// (10) Listan måste vara av typen Object för att alla klasser skall kunna lagras tillsammans.
//
// (13) När metoden Stats anropas på varje Animal-objekt blir det den mest specifika versionen av Stats som anropas.
animals.ForEach(a => System.Console.WriteLine(a.Stats()));

// (17) Vi kommer inte åt metoden ExerciseTime eftersom den är unik för endast klassen Dog.
//      För att komma åt den unika metoden kan vi iterera över listan Animals och kontrollera om typen är Dog och isf casta mha nyceklordet 'as' och kalla metoden ExerciseTime.
//      Enligt följande:
animals.ForEach(a => { if (a is Dog) { System.Console.WriteLine((a as Dog).ExerciseTime()); } });