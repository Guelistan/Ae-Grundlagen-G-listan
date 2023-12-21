// Bedingte Anweisungen und Verzweigungen sind Kontrollstrukturen. 
// Diese ermöglichen es uns, den Fluss des Codes, und damit welche Teile des Codes ausgeführt werden, zu bestimmen. 

//Booleans
using System.ComponentModel.Design;
using System.Linq.Expressions;

bool istHeuteMittwoch = false;

Console.WriteLine($" Stimmt es, dass Heute Mittwoch ist?\nAntwort: {istHeuteMittwoch}");

//Logische Operatoren
bool bl = !false;//ändert den Wert ins Gegenteil. Diese wird auch als toggle bezeichnet.
Console.WriteLine(bl);
bool b2 = true && false; // And : ergibt true, wenn alle werte true sind. //Logische Und=&&
Console.WriteLine(b2);
bool b3 = true || false; // OR: Ergibt true, wenn mindestens ein Wert true ist. 
Console.WriteLine(b3);
bool b4 = true ^ false; //Xor: ergibt true, wenn genau ein Wert true ist. 
Console.WriteLine(b4);

// Vegleichsoperatoren
//Deklaration von Variablen zur folgenden veranschaulichung der Vergleichsoperatoren:
int x1 = 1;
int x1b = 1;
int x2 = 2;
int x3 = 3;
bool b5 = (x1 == x1b); // ergibt true, wenn beide Werte gleich sind
bool b6 = (x1 <= x2);//< > <= >= kleiner, größer, kleiner gleich, größer gleich// ergibt true, wenn 
                     //Bedinugen erfüllt ist. 

Console.WriteLine(b6);
bool b7 = (x1 != x2);//!=ergibt true, wenn beide Werte nicht gleich sind.
Console.WriteLine(b7);

// Alle Operatoren können auch miteinander Kombiniert werden. 
bool b8 = (x1 < x3) ||(x3 > x2);
Console.WriteLine(b8);

//if-anweisung
bool istHeuteWerktag = true;
if (istHeuteWerktag==true) //Wenn
{//Dann
    Console.WriteLine("der Wecker klingelt um 04:00 Uhr Morgens.");

}
else //Ansonsten
{
    Console.WriteLine("Wochenende, Ausschlafen");
   
}
Console.WriteLine();

bool istHeuteDonnerstag = (DateTime.Now.DayOfWeek==DayOfWeek.Thursday);
istHeuteMittwoch = (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday);

if (istHeuteDonnerstag==true)
{
    Console.WriteLine();
}
else
{
    if (istHeuteMittwoch == true)
    {
        Console.WriteLine("Heute ist Mittwoch");
    }
    else
    {
        Console.WriteLine("Heute ist weder Mittwoch noch Donnerstag");
    }
        
}

  //aufgabe:
  

















