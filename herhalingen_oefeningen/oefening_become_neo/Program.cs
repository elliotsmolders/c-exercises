/* Volgende code genereert een beeld zoals dat ook in de cultfilm The Matrix plaatsvindt.
Vul de code aan zodat de karakters random kleuren krijgen. Kan je het nog cooler maken? */

Random rangen = new Random();
Console.ForegroundColor = ConsoleColor.Green;
while (true)
{
    //Genereer nieuw random teken:
    char teken = Convert.ToChar(rangen.Next(62, 400));
    //Zet teken op scherm
    Console.Write(teken);
    //Ietwat vertragen
    System.Threading.Thread.Sleep(10); //dit getal is in milliseconden. Speel er gerust mee.
    //random kleur
    Console.ForegroundColor = (ConsoleColor)rangen.Next(1,14);
}