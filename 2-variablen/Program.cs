//Eine Variable speichert den Wert eines bestimmten Datentyps.
//Die Deklaration(erstellen) einer Variable erfolgt im Format:
//<datentyp> <variablenname>;
//Der Variablenname wird auch "Bezeichner" genannt.
//Variablennamen dürfen nur einmal Deklariert werden.

//Beispiel für eine Integer-Variable:

int zahlEins;

//Initialisierung der Variable (erstmalige Wertzuweisung):
zahlEins = 123;
Console.WriteLine("Wert der Variable nach der Initialisierung: " + zahlEins);

//Zuweisung eines neuen Wertes durch Überschreibung:
zahlEins = -123;
Console.WriteLine("Wert der Variable nach der ersten Wertüberschreibung: " + zahlEins);
zahlEins = zahlEins + 1;
Console.WriteLine("Wert der Variable nach der zweiten Wertüberschreibung: " + zahlEins);

zahlEins = 5 / 2;
Console.WriteLine("Das Ergebnis der Division ist: " + zahlEins);

//(Gleit-)Kommazahlen:
double kommazahl1 = 2.5; //beachtet die Amerikanische Punktnotation!!
Console.WriteLine("Kommazahl: " + kommazahl1);
kommazahl1 = 5.0 / 2.0;
Console.WriteLine("Kommazahl Division: " + kommazahl1);

//Datentypen:
//Einzelnes Zeichen (Char) auch ein leerzeichen zählt hier als character
char zeichen = 'n'; // unter die Chars fällt auch das Leerzeichen
Console.WriteLine(zeichen);

//Zeichenketten(String)
string text = "Hallo World!";
Console.WriteLine(text);

//Wahrheitswerte (Boolean)
bool istHeuteDienstag = false; //Die andere möglichkeit wäre true
Console.WriteLine("stimmt es, dass heute Dienstag ist? Antwort:" + istHeuteDienstag);

//Deklaration und Initialisierung mehrerer Variablen des selben Typs
int x = 5, y = 23, z = 50;

//Zahlendatentypen und Speichergrößen:
byte eineSehrKleinePositiveZahl;//byte Größe: 1 Byte=> 8 Bit-256 Zahlen, mögliche Werte 0-255

sbyte eineSehrkleinezahl; //sbyte steht für signed, mögliche Werte:-128 bis 127
                          //
short eineKleinezahl; //int16 Größe: 2 Bytes=>2*8 Bit=16 Bit, mögliche Werte:-32768 bis 32767

ushort eineKleinePositiveZahl; //u steht für unsigned, mögliche Werte: 0-65535

int eineMittelgroßeZahl; // Int32 Größe: 4 Bytes=>4*8 Bit = 32 Bit, mögliche Werte :2^32 (ca 4,3 Milliraden) 
                         //kleinster möglicher Wert: -2147483648. Größter möglicher Wert:2147483647

uint eineMittelgropePositiveZahl; // mögliche Werte:0 bis 4294967295

//Zur besseren Lesbarkeit dürfen Zahlen in C# auch so geschrieben werden:
eineMittelgroßeZahl = 2_147_483_647;

Console.WriteLine("Maximalwert für Int32:" + kommazahl1);

int neueZahl = eineMittelgroßeZahl + 1; //Overflow: der Wert springt zum niedrigst möglichen Wert, und zählt von dort aus wieder hoch. 
Console.WriteLine("int32 Max +1 erzeugt einen Overflow:" + neueZahl);

long eineSehrGroßeZahl; //int64, mögliche Werte: -92233720368547752808 bis  9223372036854775807
ulong eineSehrGroßePositiveZahl; //0-18446744073709551616

//Kommazahlen
float einekleineKommaZahl = 0.123456789f; // 4 Byte - Das f muss angegeben werden, damit der Compiler versteht, dass es sich um einen Wert des float Datentyps handelt. 

double eineMittelgroßeKommaZahl= 0.123456789123456789d; //8 Byte- Das d kann angegeben werden, um klarzustellen, dass es sich um einen Wert des Double handelt. 

decimal eineGroßeKommazahl = 0.123456789123456789123456789m; //24 Byte-Das M muss angegeben werden, damit der Compiler versteht, dass es sich um eine Wert des Decimal Datentyp handelt. // Wenn mit Geld gerechnet werden soll, ist Decimal immer der Datentyp der Wahl. 

//Sonstige
bool wahrheit; //2 Zustände möglich=>1 Bit

char einZeichen; //2 Byte

string satz; // die größe bemisst sich nach dem inhalt des strings. 





