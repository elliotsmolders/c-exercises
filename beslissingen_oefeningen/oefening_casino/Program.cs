/* Genereer een random getal van 1 t.e.m. 6 maar toon dit niet aan de gebruiker. Vraag aan de gebruiker welk getal hij denkt dat de computer
 heeft “geworpen”. Indien de gebruiker juist raadt verschijnt er “proficiat” op het scherm. Anders: “you lose”. */

 Random randomGenerator1 = new Random();
 int getal = randomGenerator1.Next(1,7);
 Console.WriteLine("Gok het getal van 1-6");
 int gok = Convert.ToInt32(Console.ReadLine());
 if(gok == getal){
    Console.WriteLine("proficiat");
 }
 else{
    Console.WriteLine("you lose.");
 }
 Console.WriteLine($"Het getal was {getal}");