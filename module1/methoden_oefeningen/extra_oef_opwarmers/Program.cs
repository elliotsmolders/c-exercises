// Methode Kwadraat die het kwadraat van een ingevoerd getal berekend ( het getal geef je mee als parameter).
static int KwadraatBerekenen(int getal){
    return getal*getal;
}
Console.WriteLine(KwadraatBerekenen(4));

// Methode BerekenStraal die de straal van een cirkel kan berekenen waarvan je de diameter meegeeft (de diameter geef je mee als parameter).
static double BerekenStraal(int diameter){
    return diameter/2.0;
}
Console.WriteLine(BerekenStraal(3));

// Idem voor omtrek en oppervlakte.
static double BerekenOmtrek(int diameter){
    return Math.PI*diameter;
}
System.Console.WriteLine(BerekenOmtrek(3));


static double BerekenOppervlakte(int diameter){
    return Math.PI*(Math.Pow((double)diameter/2.0,2));
}
System.Console.WriteLine(BerekenOppervlakte(3));

//Methode IsEven die bepaald of een getal even of oneven is (geeft een bool terug die true is indien even).

static bool IsEven(int getal){
    return getal%2==0;
}
System.Console.WriteLine(IsEven(4));

//Methode IsArmstrong die bepaald of een getal een Armstrong getal is.

static bool IsArmstrong(int getal){
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
System.Console.WriteLine(IsArmstrong(153));
System.Console.WriteLine(IsArmstrong(154));

//Methode ToonOEvenNummers die alle oneven getallen van 1 tot n toont waarbij n als parameter wordt meegegeven.

static void ToonEvenNummers(int n){
    for(int i = 1;i<=n;i++){
        if(i%2==0){
            System.Console.WriteLine(i);
        }
    }
}
ToonEvenNummers(30);

//Methode ToonArmstrongNummers die alle Armstrong nummers tot n toont.

static void ToonArmstrongNummers(int n){
    for(int i =1; i<=n;i++){
        if(IsArmstrong(i)){
            System.Console.WriteLine(i);
        }
    }
}
ToonArmstrongNummers(400);