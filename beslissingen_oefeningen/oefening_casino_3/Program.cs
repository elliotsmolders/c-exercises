/*  Vul de voorgaande oefening aan, maar laat de gebruiker 3x na mekaar raden. Enkel als hij juist raadt mag hij nog eens raden. Als hij ook
 de derde juist raadt wint hij. In alle andere gevallen niet. */
 
 Random randomGenerator1 = new Random();
 int juisteGokken = 0;
 int aantalJuistVoorWin = 3;

 int getal = randomGenerator1.Next(1,7);
Console.WriteLine(getal);
 Console.WriteLine($"Gok een getal van 1-6 raad {aantalJuistVoorWin} keer juist om te winnen");
 int gok = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Het getal was {getal}");
if(getal==gok){
    juisteGokken++;
}
 while(juisteGokken<aantalJuistVoorWin && getal == gok){
    Console.WriteLine($"aantal juiste gokken: {juisteGokken}");
    getal = randomGenerator1.Next(1,7);
    Console.WriteLine(getal);
    Console.WriteLine("Gok een getal van 1-6");
    gok = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Het getal was {getal}");
    juisteGokken ++;
 }

Console.WriteLine($"aantal juiste gokken: {juisteGokken}");
 if(juisteGokken == aantalJuistVoorWin){
    Console.WriteLine("proficiat u hebt gewonnen");
 }
 else{
    Console.WriteLine("U hebt verloren");
 }
