/* Maak een quiz. Maak gebruik van het switch-statement om de input van de gebruiker (a, b, c of d) te verwerken en bij iedere vraag aan te
 geven of dit juist of fout is. Voorzie 3 multiple choice vragen. Houdt bij hoe vaak de speler juist antwoordde en geef op het einde de 
 eindscore (Juist is +2, fout is -1).

Zoek op hoe je de kleur van de letters en de achtergrond in een console-applicatie kunt aanpassen en pas dit toe op je quiz om deze er
iets boeiender uit te laten zien. Toon iedere vraag op een nieuw scherm. */

int score = 0;
char oplossingVraag1 = 'a';
char oplossingVraag2 = 'b';
char oplossingVraag3 = 'c';


Console.WriteLine("vraag 1: (juiste is a)");
Console.BackgroundColor=ConsoleColor.DarkGray;
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("a:");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("b:");
Console.ForegroundColor=ConsoleColor.DarkYellow;
Console.WriteLine("c:");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("d:");
Console.ResetColor();
char antwoordVraag1 = Convert.ToChar(Console.ReadLine());
if(oplossingVraag1 == antwoordVraag1){
    score+=2;
}
else{
    score -=1;
}
Console.Clear();


Console.WriteLine("vraag 2:(juiste is b)");
Console.BackgroundColor=ConsoleColor.DarkGray;
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("a:");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("b:");
Console.ForegroundColor=ConsoleColor.DarkYellow;
Console.WriteLine("c:");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("d:");
Console.ResetColor();
char antwoordVraag2 = Convert.ToChar(Console.ReadLine());
if(oplossingVraag2 == antwoordVraag2){
    score+=2;
}
else{
    score -=1;
}
Console.Clear();


Console.WriteLine("vraag 3:(juiste is c)");
Console.BackgroundColor=ConsoleColor.DarkGray;
Console.ForegroundColor=ConsoleColor.DarkBlue;
Console.WriteLine("a:");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("b:");
Console.ForegroundColor=ConsoleColor.DarkYellow;
Console.WriteLine("c:");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("d:");
Console.ResetColor();
char antwoordVraag3 = Convert.ToChar(Console.ReadLine());
if(oplossingVraag3 == antwoordVraag3){
    score+=2;
}
else{
    score -=1;
}
Console.Clear();
Console.Write($"eindscore: {score}");