namespace variableopdracht2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string merk = "Vanmoof";
        int versnellingen = 7;
        double framemaat = 54.5;
        bool heeftBel = true;


        string Pilotname = "Jack Cooper";
        int Pilotscore = 4500;
        bool Pilotdead = false;
        float weaponweight = 2.5f;


        string TournamentName = "Mediacollege Basketball Cup";
        int NumberOfTeams = 8;
        double Duration = 2.5;
        string Location = "Amsterdam";
        float EntryFee = 50.0f;
        bool IsStarted = true;
        char CourtType = 'H'; // H for Hardcourt, G for Grass, I for Binnen

        Console.WriteLine(TournamentName);
        Console.WriteLine(NumberOfTeams);
        Console.WriteLine(Duration);
        Console.WriteLine(Location);
        Console.WriteLine(EntryFee);
        Console.WriteLine(IsStarted);
        Console.WriteLine(CourtType);

    }
}




/*
🏀 C# Variable Practice Challenge

Scenario:
Imagine je bent bezig met het plannen van een kleine basketbaltoernooi-dag. Je moet gegevens bijhouden over teams, het toernooi en de locatie.

Opdracht

Maak minstens 6 variabelen die verschillende soorten informatie over dit toernooi opslaan.

Gebruik een mix van datatypen (bijv. string, int, double, bool, char).

Zorg dat elke variabele een logische naam heeft en meteen een waarde krijgt die past bij een echte toernooisituatie.

Details om over na te denken (maar geen voorbeeldcode)

Een naam of titel van het toernooi

Het aantal teams of spelers

Starttijd of duur

Locatiegegevens

Toegangskosten of prijs per ticket

Een status die aangeeft of het toernooi al gestart is

Schrijf alleen de declaraties en de toekenning (initialisatie) van deze variabelen in C#.
Geen methoden, geen functies—alleen variabelen aanmaken en een waarde geven.

*/
