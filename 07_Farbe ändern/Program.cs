using System.Drawing;

string Farbe;

Console.WriteLine("wähle die eine Farbe aus (r), (g), (b), (rainbow mode)");
Farbe = Console.ReadLine();


if (Farbe == "Rot" || Farbe == "rot" || Farbe == "R" || Farbe == "r")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Deine Farbe wurde geändert");
    Console.ReadLine();
}
else if (Farbe == "Grün" || Farbe == "grün" || Farbe == "G" || Farbe == "g")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Deine Farbe wurde geändert");
    Console.ReadLine();
}
else if (Farbe == "Blau" || Farbe == "blau" || Farbe == "B" || Farbe == "b")
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Deine Farbe wurde geändert");
    Console.ReadLine();
}




