// Übungen
//liste mit 4 namen
Console.WriteLine(" Gib deinen Namen ein");
string userinput = Console.ReadLine();

Console.WriteLine("was ist dein hobby");
string hobbys = Console.ReadLine();

Console.WriteLine("was ist dein lieblingsbuch");
string Lieblingsbuch = Console.ReadLine();

Console.WriteLine("wie vile geld hast du?");
double geld = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"du hast {geld} euro auf dem Konto");
Console.WriteLine();


Console.WriteLine("Gib deinen Namen ein");
string userinput1 = Console.ReadLine();

Console.WriteLine("was ist dein hobby");
string hobbys1 = Console.ReadLine();

Console.WriteLine(" was ist dein lieblingsbuch");
string Lieblingsbuch1 = Console.ReadLine();

Console.WriteLine("Wie viel geld hast du?");
double geld1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" du hast {geld1} euro auf dem Konto \n\n");


double ergebnis = geld + geld1;
Console.Write("ihr habt zusammen " );
Console.Write(ergebnis);
Console.Write( " Euro");
Console.WriteLine();

Console.WriteLine("ich nehme die hälfte von eurem geld");
ergebnis = (geld + geld1) / 2d;
Console.Write(ergebnis);









