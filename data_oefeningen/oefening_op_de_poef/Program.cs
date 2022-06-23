/* Een vaste klant in je café besteld altijd “op-de-poef”. Dat wil zeggen dat hij niet betaald en dat z’n rekeningen worden neergeschreven.
 Ooit zal de klant dan gevraagd worden de hele som te betalen. Schrijf een programma dat 5 keer na elkaar aan de barman vraagt om
  een bedrag in te voeren. Het ingevoerde bedrag wordt opgeteld bij wat er reeds op de rekening staat. Na 5 keer wordt de totale som getoond
   alsook hoeveel weken het duurt indien de klant wekelijks 10 euro afbetaald. */
double som = 0;
for(int i = 0; i<5;i++){
    Console.WriteLine("Voer bedrag in?");
    som += Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"De poef staat op {som} euro.");
}
Console.WriteLine("*************************");
double wekelijkseAfbetaling = 10;
Console.WriteLine($"Het totaal van de poef is {som} euro en zal {((wekelijkseAfbetaling - som % wekelijkseAfbetaling)+som)/wekelijkseAfbetaling} weken duren ");
