/* De plaatselijke voetbalclub organiseert een mosselfestijn. Naast mosselen met frietjes (20 EUR) bieden ze voor de kinderen de mogelijkheid
 om een koninginnehapje (10 EUR) te kiezen. Verder is er een ijsje als nagerecht voorzien (3 EUR). Om het gemakkelijk te maken kosten alle 
 dranken 2 EUR.

Ontwerp een applicatie zodat de vrijwilliger aan de kassa alleen maar de juiste aantallen moet ingeven, lijn per lijn.
 (frietjes, koninginenhapje, ijsje, drank) om de totaal te betalen prijs te berekenen.

Het resultaat wordt als volgt weergegeven: Het totaal te betalen bedrag is x EURO. */

double prijsFrieten = 20;
double prijsKoninginnehapje = 10;
double prijsIjsje = 3;
double prijsDranken = 2;
double som = 0;
Console.WriteLine("Geef het aantal frietjes:");
byte aantalFrieten = Convert.ToByte(Console.ReadLine());
som+=aantalFrieten*prijsFrieten;
Console.WriteLine($"tussensom = {som}");
Console.WriteLine("Geef het aantal koninginnehapjes:");
byte aantalKoninginnehapjes = Convert.ToByte(Console.ReadLine());
som+= aantalKoninginnehapjes*prijsKoninginnehapje;
Console.WriteLine($"tussensom = {som}");
Console.WriteLine("Geef het aantal ijsjes:");
byte aantalIjsjes = Convert.ToByte(Console.ReadLine());
som+=aantalIjsjes*prijsIjsje;
Console.WriteLine($"tussensom = {som}");
Console.WriteLine("Geef het aantal dranken:");
byte aantalDranken = Convert.ToByte(Console.ReadLine());
som+=aantalDranken*prijsDranken;
Console.WriteLine($"Het totaal te betalan bedrag is {som} euro.");
