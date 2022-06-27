/* Muziek maken (Wikipedia) [http://nl.wikipedia.org/wiki/Toonhoogte] leert ons dat de grondtonen do-re-mi-fa-sol-la-si-do de frequenties 
: 264-297-330-352-396-440-495-528 hz behelsen (excuses indien dit jargon niet klopt. Ik ken even veel van muziek als van metsen).

De Console.Beep() methode laat ons toe om tonen te genereren op een bepaalde frequentie (in Hz) en van een bepaalde duur (in milliseconden,
 i.e. 1/1000 van een seconde).

We kunnen dus de computer de toonladder afspelen, elke noot 1 seconde lang, als volgt:

Console.Beep(264, 1000);
Console.Beep(297, 1000);
Console.Beep(330, 1000);
Console.Beep(352, 1000);
Console.Beep(396, 1000);
Console.Beep(440, 1000);
Console.Beep(495, 1000);
Console.Beep(528, 1000); */

/* Opgave 1
Zorg ervoor dat je bovenstaande als volgt kunt aanroepen:

Do();
Re();
Mi();
Fa();
Sol();
La();
Si();
Do2();
Iedere methode zal dus de correcte toon afspelen gedurende 1s (je mag dit ook sneller instellen naar keuze). */
/* static void Do(){
    Console.Beep(264, 1000);
}
static void Re(){
    Console.Beep(297, 1000);
}
static void Mi(){
    Console.Beep(330, 1000);
}
static void Fa(){
    Console.Beep(352, 1000);
}
static void Sol(){
    Console.Beep(396, 1000);
}
static void La(){
    Console.Beep(440, 1000);
}
static void Si(){
    Console.Beep(495, 1000);
}
static void Do2(){
    Console.Beep(528, 1000);
} */

/* Opgave 2
Iedere ‘noot-methode’ zal ook steeds op het scherm tonen welke noot wordt afgespeeld (doe dit als eerste in de methode) De uitvoer van opgave
 één wordt dan:Do
Re
Mi
Fa
Sol
La
Si
Do
Extra: plaats ieder noot in een andere tekstkleur (m.b.v. Console.ForeGroundColor)
 */
/* static void Do(){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Do");
    Console.Beep(264, 1000);
}
static void Re(){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Re");
    Console.Beep(297, 1000);
}
static void Mi(){
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Mi");
    Console.Beep(330, 1000);
}
static void Fa(){
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Fa");
    Console.Beep(352, 1000);
}
static void Sol(){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Sol");
    Console.Beep(396, 1000);
}
static void La(){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("La");
    Console.Beep(440, 1000);
}
static void Si(){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Si");
    Console.Beep(495, 1000);
}
static void Do2(){
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Do");
    Console.Beep(528, 1000);
}
 */

 /* Oefening 3
Door een de frequentie van een toon te vermenigvuldigen of te delen met veelvouden van 2 krijg je de tonen op andere octaven. Pas de ‘noot-methoden’ aan zodat 2 parameters kunnen meegeven worden:

De lengte in milliseconden dat de toon moet aangehouden worden
De octaaf van de toon: 1 = basis octaaf die we al hadden, 2= 2e octaaf (dus frequentie x2) 3= 3e octaaf (frequentie x 3) etc.
  */
static void Do(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Do");
    Console.Beep(264*octaaf, lengte);
}
static void Re(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Re");
    Console.Beep(297*octaaf, lengte);
}
static void Mi(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Mi");
    Console.Beep(330*octaaf, lengte);
}
static void Fa(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Fa");
    Console.Beep(352*octaaf, lengte);
}
static void Sol(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Sol");
    Console.Beep(396*octaaf, lengte);
}
static void La(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("La");
    Console.Beep(440*octaaf, lengte);
}
static void Si(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Si");
    Console.Beep(495*octaaf, lengte);
}
static void Do2(int lengte=500, int octaaf=1){
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Do");
    Console.Beep(528*octaaf, lengte);
}
Do(500,2);
Re(500,2);
Mi(500,2);
Fa(500,2);
Sol(500,2);
La(500,2);
Si(500,2);
Do2(500,2);
