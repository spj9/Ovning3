
//3.1 Inkapsling
internal class Program
{
    private static void Main(string[] args)
    {
        var personHandler = new PersonHandler();
        Person person1;
        Person person2;
        Person person3;
        try
        {
            person1 = personHandler.CreatePerson(20, "Anders", "Andersson", 181, 85);
            //person2 = personHandler.CreatePerson(30, "Zlatan", "Ibrahimovic", 198, 90);
            //person3 = personHandler.CreatePerson(40, "Greta", "Garbo", 159, 55);
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }

        //Console.WriteLine("Test");
    }
}

//3.2 Polymorfism


//3.3 Arv

// (13) Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
//      bör vi lägga det attributet i klassen Bird, eftersom alla klasser av typen fågelart ärver från denna.
//
// (14) Om alla djur behöver ett nytt attribut bör vi lägga det i klassen Animal.

//3.4 Mer polymorfism

// (9)  Det går inte att lägga till en häst i listan av hundar därför att vi definierat att listan ska innehålla objekt av klassen hund.
//
// (10) Listan måste vara av typen Animal för att alla klasser skall kunna lagras tillsammans.
//
// (13) 
//      
// (17)
