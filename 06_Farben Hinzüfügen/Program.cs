// Farben Hinzüfügen/ Mehrstufige Auswahl


string m1;


Console.WriteLine("Welche farbe haben Kirschen?");
m1 = Console.ReadLine();

if (m1 == "Rot" || m1 == "rot"|| m1 == "R" || m1 == "r")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Kirschen schmecken lecker.\n");
}
else
{
    Console.WriteLine(" frag lieber deinen Hund, er kennt es besser!\n");
}



Console.WriteLine("Welche farbe hat das Gras?\n");
m1 = Console.ReadLine();
if (m1 == "Grün" || m1 == "grün" || m1 == "g")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("grüner geht es nicht mehr.\n");
}
else
{ 
    Console.WriteLine("du hast dir keine farbe ausgesucht oder,");
    Console.WriteLine($"du hast die falsche farbe ausgesucht.\n");
}



Console.WriteLine("Welche farbe hat die Milka KUh?\n");
m1 =Console.ReadLine();
if  (m1== "Lila" || m1 == "lila" || m1 == "L" || m1 == "l")
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Milka Kuh");
}
else
{
    Console.WriteLine("schon wieder die falsche farbe,");
    Console.WriteLine($"kauf dir eine brille");
}

Console.WriteLine("Welche farbe hat ein regenbogen");
Console.ReadLine();


{

    ConsoleColor[] farben = new ConsoleColor[]

    {

        ConsoleColor.Red,

        ConsoleColor.Green,

        ConsoleColor.Blue,

        ConsoleColor.Yellow,

        ConsoleColor.Cyan,

        ConsoleColor.Magenta,

    };

    while (true)

    {

        foreach (ConsoleColor farbe in farben)

        {

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)

            {

                return;

            }

            Console.Clear();

            Console.ForegroundColor = farbe;

            Console.WriteLine("*****************************************Rainbow Mode*****************************************");

            Thread.Sleep(50);

        }

    }

}

Console.ReadKey();



string farbe = Console.ReadLine().ToLower();//Damit werden alle Buchstaben klein geschrieben

if (farbe == "rot" || farbe == "r")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Die Farbe ist nun auf Rot geändert");
}
else if (farbe == "blau" || farbe == "b")
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Die Farbe ist nun auf Blau geändert");
}