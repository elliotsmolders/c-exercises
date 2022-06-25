/* Een getal is een narcistisch getal of armstronggetal als het de som is van zijn eigen cijfers elk tot de macht verheven van het aantal
 cijfers.

9 is een Armstrong nummer, want 9 = 9^1 = 9
10 is geen Armstrong nummer, want 10 != 1^2 + 0^2 = 1
153 is een Armstrong nummer, want: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
154 is geen Armstrong nummer, want: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190
Schrijf een programma dat aan de gebruiker een getal vraagt en vervolgens toont of het ingevoerde getal een Armstrong-nummer is of niet. */

Console.WriteLine("voer een getal in:");
string inputGetalString = Console.ReadLine();

int lengteGetal = inputGetalString.Length;
int getal = Convert.ToInt32(inputGetalString,10);
int tijdelijkGetal = getal;

int som = 0;
for (int i = 0; i < lengteGetal; i++)
{   //Console.WriteLine(tijdelijkGetal%10);
    som += (int)Math.Pow(tijdelijkGetal%10,lengteGetal);
    //Console.WriteLine(som);
    tijdelijkGetal = tijdelijkGetal / 10;
    //Console.WriteLine(tijdelijkGetal);
}
if(som == getal){
    Console.WriteLine($"{getal} is een armstrongnummer");
}
else{
    Console.WriteLine($"{getal} is geen armstrongnummer");
}