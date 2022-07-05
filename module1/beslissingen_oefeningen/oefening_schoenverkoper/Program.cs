/* a) Maak een oefening die aan de gebruiker vraagt hoeveel paar schoenen hij wenst te kopen. Ieder paar schoenen kost steeds 20 euro. 
Indien de gebruiker 10 paar of meer koopt kosten de eerste 9 paar nog steeds 20 euro, de overige kosten echter maar 10 euro.
 Toon aan de gebruiker de totale prijs.

Voorbeeld:

8 schoenen kost 8×20 = 160 euro
12 schoenen kost 9×20 + 3×10 = 210 euro
b) Voeg nu toe dat het programma eerst aan de kassier vraagt tot hoeveel schoenen de korting niet geldt.

Voorbeeld:

De kassiester voert 6 in. Dan kosten 8 schoenen: 6×20 + 2×10 = 140 euro. */

Console.WriteLine("tot hoeveel schoenen geldt de korting niet?");
int kortingVanaf = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hoeveel schoenen wens je te kopen?");
int aantalSchoenen = Convert.ToInt32(Console.ReadLine());
int prijsSchoenZonderKorting = 20;
int prijsSchoenMetKorting = 10;
int total = 0;
if(aantalSchoenen>=kortingVanaf){
    int schoenenMetKorting = (aantalSchoenen-kortingVanaf);
    total += schoenenMetKorting*prijsSchoenMetKorting + (aantalSchoenen - schoenenMetKorting)*prijsSchoenZonderKorting;
}
else{
    total += aantalSchoenen*prijsSchoenZonderKorting;
}
Console.WriteLine($"De totale prijs is: {total}");