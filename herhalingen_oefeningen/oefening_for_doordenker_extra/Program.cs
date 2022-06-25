/* [PRO] For doordenker extra
Schrijf een programma dat de volgende output geeft (zie ook WhileDoordenker van vorige labo), gegeven dat de gebruiker een maximum waarde
 invoert die opgeeft uit hoeveel lijnen de boom bestaat.
 Maak enkel gebruik van for-loops. */
 Console.WriteLine("maximum hoogte boom:");
 int hoogte = Convert.ToInt32(Console.ReadLine());
 for (int i = 0; i < hoogte ; i++)
 {  string spaties = new String(' ',hoogte-1-i);
    string sterren = new String('*',(i+1)*2-1);
    Console.WriteLine(spaties+sterren);
 }