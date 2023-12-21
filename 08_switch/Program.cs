// See Mehrseitige Fallauswahl:Switch:
using System.Security.AccessControl;
Console.WriteLine("Such dir eine farbe aus");
string farbe = Console.ReadLine().ToLower();


switch (farbe)
{
    case "r":
    case "rot":
    Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Die farbe ist rot geändert");

        break;
    case "g":
    case "Gelb":
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Die farbe ist nun auf Gelb geändert");
        break;
    default:
        Console.WriteLine("ungültige eingabe");
        break;
        
}
