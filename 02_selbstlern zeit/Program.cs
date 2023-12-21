//[15:05] Meinel Fabian
//Aufgabe:

//Der User soll ein zuvor, von euch, festgelegtes Passwort eingeben. Er hat drei Versuche um es Richtig einzugeben.

//Nach jedem Fehlversuch soll angegeben werden, wieviele Versuche noch übrig sind.

//Nach dem dritten Fehlversuch soll die Meldung kommen: "Konto gesperrt!".

//Bei einer richtigen Antwort eine Meldung das das Passwort Korrekt eingegeben 




using System.ComponentModel.Design;

string password = "lulu123";
string eingabe;
Console.WriteLine("gebe bitte dein Passwort ein:");
Console.WriteLine("1.versuch:");
eingabe =Console.ReadLine();


if (eingabe == password)
{
    Console.WriteLine("Das Passwort war richtig");
    Console.WriteLine("0,30 Euro");
}
else
{
    Console.WriteLine("versuchen sie noch einmal bitte");
    Console.WriteLine("2. versuch:");
    eingabe = Console.ReadLine();
    if (eingabe == password) 
    {
        Console.WriteLine("ihr passwort war richtig");
        

     
    }
else
    {
        Console.WriteLine("letzter Versuch");
        Console.WriteLine("3.versuch:");
        eingabe = Console.ReadLine();
        if (eingabe == password) { }
            Console.WriteLine("ihr konto ist gesperrt");
        Console.WriteLine("Schreib das nächste mal dein passwort auf");
        
           
        

        
    }
}












