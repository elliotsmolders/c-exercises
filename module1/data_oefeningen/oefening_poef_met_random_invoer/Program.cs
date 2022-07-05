/* Pas 1 van bovenstaande programma’s aan zodat je de invoer niet meer aan de gebruiker vraagt, maar deze genereert door een random generator.
 Zorg ervoor dat je realistische waarden genereert. */
 
Random randomGenerator = new Random();
double som = 0;
for(int i = 0; i<5;i++){
    Console.WriteLine("Voer bedrag in?");
    som += Math.Round(randomGenerator.NextDouble() * 20.0,2);
    Console.WriteLine($"De poef staat op {som} euro.");
}
Console.WriteLine("*************************");
double wekelijkseAfbetaling = 10;
Console.WriteLine($"Het totaal van de poef is {som} euro en zal {((wekelijkseAfbetaling - som % wekelijkseAfbetaling)+som)/wekelijkseAfbetaling} weken duren ");
