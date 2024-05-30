
//3.1) Inkapsling
//Skapa en klass Person och ge den följande privata fält: age, fName, lName, height, weight

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