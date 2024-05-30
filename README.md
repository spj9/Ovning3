# C# �vningssamling - Inkapsling, arv och polymorfism
L�pande i uppgifterna finns n�gra kunskapsfr�gor (startar med �F:�). Dessa fr�gor besvaras som kommentarer i koden. Koden beh�ver inte ta emot input fr�n en anv�ndare.
### 3.1) Inkapsling
1. Skapa en klass Person och ge den f�ljande privata f�lt:
   
   _age, fName, lName, height, weight_
   
Skapa publika properties med get och set som h�mtar eller s�tter tilldelad variabel. Instansiera en person i Program.cs, kommer du direkt �t variablerna?

Implementera validering i de skapade properties:
- Age kan bara tilldelas ett v�rde st�rre �n 0.
- FName �r obligatorisk och f�r inte vara mindre �n 2 tecken eller l�ngre �n 10
tecken.
- LName �r obligatorisk och f�r inte vara mindre �n 3 tecken eller st�rre �n 15
tecken.

Kasta ett undantag av typen ArgumentException i varje property om dess validering inte fullf�ljs, undantaget ska inneh�lla ett beskrivande meddelande.
Se till att hantera undantagen i Program-klassen med en try-catch block.

2. F�r att inkapsla Person-objekten ytterligare skall vi skapa klassen PersonHandler - en klass vars syfte �r att skapa och hantera dina Person-objekt.
I PersonHandler-klassen skapa metoden:

    public void SetAge(Person pers, int age)
   
Anv�nd den inskickade personens Age property f�r att s�tta personens age-attribut via SetAge-metoden. Ist�llet f�r att enbart anv�nda en property har vi nu abstraherat med tv� lager.

3. I PersonHandler, skriv en metod som skapar en person med angivna v�rden:

   public Person CreatePerson(int age, string fname, string lname, double height, double weight)
   
4. Forts�tt skapa metoder i PersonHandler f�r att kunna hantera samtliga operationer som man kan vilja g�ra med en Person.
    
5. N�r denna klass �r klar, kommentera bort er tidigare instans av Person fr�n Program.cs, och instansiera ist�llet en PersonHandler. Skapa d�rigenom n�gra personer och testa era metoder.
### 3.2) Polymorfism
1. Skapa den abstrakta klassen UserError

2. Skapa den abstrakta metoden UEMessage() som har returtypen string.

3. Skapa en vanlig klass NumericInputError som �rver fr�n UserError

4. Skriv en override f�r UEMessage() s� att den returerar �You tried to use a
numeric input in a text only field. This fired an error!�

5. Skapa en vanlig klass TextInputError som �rver fr�n UserError

6. Skriv en override f�r UEMessage() s� att den returerar �You tried to use a text
input in a numeric only field. This fired an error!�

7. I Program.cs Main-metod: Skapa en lista med UserErrors och populera den med instanser av NumericInputError och TextInputError.

8. Skriv ut samtliga UserErrors UEMessage() genom en foreach loop.

9. Skapa nu tre egna klasser med tre egna definitioner p� UEMessage()

10. Testa och se s� det fungerar.
### 3.3) Arv
1. Skapa abstrakta klassen Animal
2. Fyll klassen Animal med egenskaper (properties) som alla djur b�r ha. Tex namn,
vikt, �lder.
3. Skapa en abstrakt metod som heter DoSound().
4. L�gg till en konstruktor.
5. Skapa Subklasserna (�rver fr�n Animal): Horse, Dog, Hedgehog, Worm och
Bird, Wolf.
6. Ge dessa minst en unik egenskap var. Vilken egenskap det �r �r inte det viktiga h�r.
Exempel Worm: IsPoisonous, Hedgehog: NrOfSpikes , Bird: WingSpan osv.
7. Implementera s� att DoSound() metoden skriver ut hur djuret l�ter..
8. Skapa nu f�ljande tre klasser: Pelican, Flamingo och Swan. Dessa ska �rva
fr�n Bird.
9. Ge dessa minst en unik egenskap var.
10. Skapa gr�nssnittet (interface) IPerson med en metod deklaration Talk();

11. Skapa klassen Wolfman som �rver fr�n Wolf och implementerar IPerson gr�nssnittet.
12. Implementera Talk() som skriver ut vad Wolfman s�ger.
13. F: Om vi under utvecklingen kommer fram till att samtliga f�glar beh�ver ett nytt
attribut, i vilken klass b�r vi l�gga det?
14. F: Om alla djur beh�ver det nya attributet, vart skulle man l�gga det d�?
### 3.4) Mer polymorfism
1. Skapa metoden Stats() i klassen Animal som har returtypen string. Metoden ska kunna overridas i dess Subklasser. Metoden ska returnera alla egenskaper (properties) som djuret har.

2. Skriv en override f�r Stats() i subklasserna f�r Animal s� den returnerar alla properties f�r det djuret.

3. Skapa en lista Animals i Program.cs som tar emot djur.

4. Skapa n�gra djur (av olika typ) i din lista.

5. Skriv ut vilka djur som finns i listan med hj�lp av en foreach-loop

6. Anropa �ven Animals Sound() metod i foreach-loopen.

7. G�r en check i for-loopen ifall ett djur �ven �r av typen IPerson, om den �r det
type-castatillIPersonochanropadessTalk() metod.

8. Skapa en lista f�r hundar.

9. F: F�rs�k att l�gga till en h�st i listan av hundar. Varf�r fungerar inte det?

10. F: Vilken typ m�ste listan vara f�r att alla klasser skall kunna lagras tillsammans?

11. Skriv ut samtliga Animals Stats() genom en foreach loop.

12. Testa och se s� det fungerar.

13. F: F�rklara vad det �r som h�nder.

14. Skriv ut Stats() metoden enbart f�r alla hundar genomen foreach p�
Animals.

15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
str�ng.

16. Kommer du �t den metoden fr�n Animals listan?

17. F: Varf�r inte?

18. Hitta ett s�tt att skriva ut din nya metod f�r dog genom en foreach p� Animals.

Lycka till!
