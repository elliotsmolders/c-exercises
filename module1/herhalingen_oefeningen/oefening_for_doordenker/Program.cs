/* [PRO] For doordenker
Schrijf een programma dat de volgende output geeft, gegeven dat de gebruiker een maximum waarde invoert, dus als hij 4 ingeeft dan zal
 de driehoek maximum 4 breed worden. Gebruik enkel for-loops! */
 
 Console.WriteLine("geef breedte driehoek:");
 int breedte = Convert.ToInt32(Console.ReadLine());

 for (int i = 1; i < breedte; i++)
 {
    string starsToWrite = "";
    for (int j = 0; j < i; j++)
    {
        starsToWrite += "*";
    }
    Console.WriteLine(starsToWrite);
 }

 for (int i = breedte; i >= 1; i--)
 {
    string starsToWrite = "";
    for (int j = 0; j < i; j++)
    {
        starsToWrite += "*";
    }
        Console.WriteLine(starsToWrite);
 }