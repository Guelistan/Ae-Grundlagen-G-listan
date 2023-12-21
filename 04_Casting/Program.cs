// casting ist die einfachste Möglichkeit, einen Datentyp in einer anderen zu Konvertieren. 

short klein = 1;
int mittel = klein;//impliziertes Castin: ein kleinerer Datentyp wird zu einem größeren Datentyp. 

mittel = 32767 + 1;
klein = (short)mittel;//explizites  Casting: in den Klammern wird der Zieldatentyp angegeben. 
Console.WriteLine(klein);

double kommazahl = 5.5;
int ganzzahl = (int)kommazahl;
double nachkommawert = kommazahl - ganzzahl;
Console.WriteLine($"{nachkommawert} ist der wert nach dem Komma von {kommazahl}");
// Mit Hilfe der Convert-Klasse können wir einen String in einen Zahlendatentyp konventieren. 
string zeichenkette = "23"; // Dieser String lässt sich nach Int Konvertieren 
string zeichenkette2 = "2b";// Dieser String lässt sich dank des b nicht zu Int Konventieren. 

int zahl = Convert.ToInt32(zeichenkette);

//Beispiel
string name;
int alter;

Console.WriteLine("Hallo User! Bitte gib deinen Namen ein.");
name = Console.ReadLine();

Console.WriteLine("Gib bitte nun dein Alter ein.");
string alternativAlter = Console.ReadLine();
alter = Convert.ToInt32(alternativAlter);
Console.WriteLine($"Hallo {name}. In einem Jahr bist du {alter + 1} Jahre alt.");

//Aufgabe: Es soll eine zweite Person Name und Alter angeben. Dann sll das durchscnittsalter der beiden Personen berechnet und ausgegeben werde



string name1;
int alter1;

Console.WriteLine("Hallo User! Bitte gib deinen Namen ein.");
name1 = Console.ReadLine();

Console.WriteLine("?Gib bitte nun dein Alter ein.");
//schreibweise wie bei person1
//string alter2strin=Console.ReadLine()
//alter2= Convert.ToInt32(alter2string)

//alternative, kürze schreibweise
//alter2 = Convert.ToInt32(Console.ReadLine());
string alternativAlter1 = Console.ReadLine();
alter1 = Convert.ToInt32(alternativAlter1);
double durchschnittsalter=(alter1 + alter) / 2d;
Console.WriteLine($"euer Durchschnittsalter beträgt{durchschnittsalter}jahre");





























