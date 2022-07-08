/* Zorg ervoor dat de opwarmers uit Deel 0 oefeningen hiervoor steeds minstens 1 optionele parameter hebben. Roep deze methoden aan via named
 parameters.
 */

//DEEL 0 OEFENINGEN

// Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als parameter).
static int KwadraatBerekenen(int getal=5){
    return getal*getal;
}
Console.WriteLine(KwadraatBerekenen(getal:4));

// Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
static double BerekenStraal(int diameter=5){
    return diameter/2.0;
}
Console.WriteLine(BerekenStraal(diameter:3));

// Idem voor omtrek en oppervlakte.
static double BerekenOmtrek(int diameter=6){
    return Math.PI*diameter;
}
System.Console.WriteLine(BerekenOmtrek(diameter:3));


static double BerekenOppervlakte(int diameter=7){
    return Math.PI*(Math.Pow((double)diameter/2.0,2));
}
System.Console.WriteLine(BerekenOppervlakte(diameter:3));

//Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).

static bool IsEven(int getal=7){
    return getal%2==0;
}
System.Console.WriteLine(IsEven(getal:4));

//Methode IsArmstrong die bepaald of een getal een Armstrong getal is.

static bool IsArmstrong(int getal=44){
int tijdelijkGetal = getal;
int lengteGetal = getal.ToString().Length;

int som = 0;
for (int i = 0; i < lengteGetal; i++)
{
    som += (int)Math.Pow(tijdelijkGetal%10,lengteGetal);
    tijdelijkGetal = tijdelijkGetal / 10;
}
    return getal == som;
}
System.Console.WriteLine(IsArmstrong(getal:153));
System.Console.WriteLine(IsArmstrong(getal:154));

//Methode ToonOEvenNummers die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.

static void ToonEvenNummers(int n=35){
    for(int i = 1;i<=n;i++){
        if(i%2==0){
            System.Console.WriteLine(i);
        }
    }
}
ToonEvenNummers(n:30);

//Methode ToonArmstrongNummers die alle Armstrong nummers tot n toont.

static void ToonArmstrongNummers(int n=200){
    for(int i =1; i<=n;i++){
        if(IsArmstrong(i)){
            System.Console.WriteLine(i);
        }
    }
}
ToonArmstrongNummers(n:400);