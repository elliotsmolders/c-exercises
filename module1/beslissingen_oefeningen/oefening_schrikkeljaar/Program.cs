/* De gebruiker voert een jaartal in en jouw programma toont of het wel of geen schrikkeljaar is. Een schrikkeljaar is deelbaar door 4, 
behalve als het ook deelbaar is door 100, tenzij het wél deelbaar is door 400. Bijvoorbeeld:

1997: geen schrikkeljaar
1996: wél schrikkeljaar
1900: geen schrikkeljaar
2000: wél schrikkeljaar */

Console.WriteLine("Geef een jaartal:");
int jaar = Convert.ToInt32(Console.ReadLine());
if(jaar%4==0 && (jaar%100!=0 || jaar%400==0)){
    Console.WriteLine($"{jaar}: wel een schrikkeljaar");
}
else{
    Console.WriteLine($"{jaar}: geen schrikkeljaar");
}