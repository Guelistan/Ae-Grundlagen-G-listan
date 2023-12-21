

Console.WriteLine("Hallo User! Bitte gib deinen Namen ein");

// Mit der Methode Console.ReadLine(); kann man die nächste Zeile, in unserem Fall das, was der User eingegeben wird, einlesen. //Es wird automatisch als String, also eine Zeichenkette, eingelesen. //Diese Zeichenkette muss in einer Variable gespeichert werden. Der Wert, also der Inhalt der varible, ist dann zur Laufzeit des Programms im Arbeitsspeicher vorhanden. 
string userinput; 
userinput = Console.ReadLine();
//Ausgabe des im Arbeitsspeicher vorligeneden Wertes über die Variable userInput
Console.WriteLine("Du hast folgendes eingegeben:\t\t" + userinput + "\n");
Console.WriteLine("Das hast du bis hierhin gut gemacht user");
Console.WriteLine("Gib bitte deinen Vornamen ein");
string vorname = Console.ReadLine();
//Aufgabe: Der User soll neben seinem Vornamen auch den Nachnamen, E-Mail_Adresse, Hobby und Alter eingeben können. 
//Gebt dann die gespeicherten Daten in der Konsole aus. 
string nachname, email, hobby, alter;



Console.WriteLine("Gib bitte deinen Nachnamen ein:");

nachname = Console.ReadLine();

Console.WriteLine("Gib bitte nun deine E-Mail Adresse ein.");

email = Console.ReadLine();

Console.WriteLine("Verrate uns bitte dein Hobby");

hobby = Console.ReadLine();

Console.WriteLine("Zum Schluss gib bitte noch dein Alter an.");

alter = Console.ReadLine();

Console.WriteLine("Deine Angegebenen Daten:\n\n" +nachname+ "\n" + email + "\n" + hobby + "\n" + alter);

//Alternative Möglichkeit

Console.WriteLine($"\n\nDeine angegebenen Daten:\n\nNachname:\n\t{nachname}\nEmail:\n\t{email}\nHobby\n\t{hobby}\nAlter\n\t{alter}\n");











