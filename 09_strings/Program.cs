//string hello = "Hello World!";// index Op. fangen immer bei Null an.
//[]-Operator: Index-Operator:
//char zeichen1 = hello[0];//index o ist das erste Zeichen in dieser Zeichenkette->H
//char zeichen2 = hello[1];// index 1 ist das zewite Zeichen in dieser Zeichenkette->e
//char zeichen5 = hello[5];// ist der wert ''das Leerzeichen


//int laenge = hello.Length;// länge der Zeichenkette, also die Anzahl der Zeichen.
//Console.WriteLine(laenge);
//char letzteZeichen = hello[laenge -1 ];
// maximale lenge minus -1 z.B. Hello world=12 zeichen minus -1.gleich 0.1.2.3.4.5 usw....die tatsächliche Anzahl an Zeichen in der Zeichenkette an. So gleichen wir aus, das bei 0 zu zählen bekommen wird. 
//Console.WriteLine(letzteZeichen);
//0=h,1=a,2=l,3=l,4=o,5= ,6=W usw..



//Aufgabe:

//Ein User soll eine Postleitzahl eingeben können.

//Es wird geprüft, ob die PLZ fünf Stellen hat. 

//Ist dies nicht der Fall, soll "Ungültige PLZ" in der Konsole ausgegeben werden. 

//Ist die PLZ korrekt, soll die zugehörige Region ermittel und in der Konsole ausgegeben werden. 

//Postleitzahlregionen:     Mit 0 oder 1 beginnend  => Ostdeutschland

//                          Mit 2 beginnend         => Norddeutschlan

;
//                          Mit 4 oder 5 beginnend  => Westdeutschland
//                          Mit 6,7,8 oder 9 beginnend => Süddeutschlan

Console.WriteLine("gib deine postleitzahl ein:[]");
string postleitzahl = Console.ReadLine();
int laenge = postleitzahl.Length;
char anganfsziffer = postleitzahl[0];
 if((laenge!=5)&& anganfsziffer == '0' || anganfsziffer == '1')
{
    Console.WriteLine("Du lebst noch in guten alten Zeiten im Osten.");
    Console.ReadLine();
}
else if (anganfsziffer == '2' || anganfsziffer == '3')
{

    Console.WriteLine("Du kommst aus dem Norden.");
    Console.ReadLine();
}
else if (anganfsziffer == '4' || anganfsziffer == '5')
{
    Console.WriteLine("Du kommst aus dem westen Deutschlands.");
}
else if(anganfsziffer == '6' || anganfsziffer == '7' || anganfsziffer == '8' || anganfsziffer == '9')
{
    Console.WriteLine("Du kommst aus dem Süden Deutschlands.");
}
 




