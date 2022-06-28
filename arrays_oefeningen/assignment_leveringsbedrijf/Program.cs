/* Maak een programma voor een koeriersbedrijf. Maak een array die 10 postcodes bevat (zelf te kiezen) van gemeenten waar het bedrijf naar 
levert. Maak een tweede array die de prijs bevat per kg van iedere respectievelijke gemeente. Het eerste element van deze array bevat dus de
 prijs/kg om naar de gemeente die als eerste in de array met postcodes staat.

Vraag aan de gebruiker een postcode en het gewicht van het pakket. Vervolgens wordt de prijs opgezocht voor die gemeente en wordt deze
 berekend gegeven het ingegeven gewicht.

Indien het bedrijf niet levert aan de ingetypte postcode dan wordt een foutmelding weergegeven.
Geef gewicht pakket
45
Naar welke postcode wenst u dit pakket te versturen?
2020
Dit zal 9630 euro kosten. */

int[] postcodes = {1000,1030,1040,1050,1060,1070,1080,1090,1140,1180};
double[] prijzenKg = {1,2,3.4,1.2,2.3,3.2,4.5,0.6,3.6,2.5};

static int IsGetalInArray (int getalToCheck, int[]arr ){
    return Array.FindIndex(arr,getal=>getal==getalToCheck);
}

static double vraagGewicht(){
    Console.WriteLine("geef gewicht:");
    return Convert.ToDouble(Console.ReadLine());
}

static int vraagPostcode(){
    Console.WriteLine("Postcode:");
    return Convert.ToInt32(Console.ReadLine());
}

int postcodeInput = vraagPostcode();
int indexPostcode = IsGetalInArray(getalToCheck:postcodeInput,arr:postcodes);
while(indexPostcode==-1){
    System.Console.WriteLine("We leveren niet naar deze postcode");
    postcodeInput = vraagPostcode();
    indexPostcode = IsGetalInArray(getalToCheck:postcodeInput,arr:postcodes);
}
double gewicht = vraagGewicht();
System.Console.WriteLine($"Dit zal {prijzenKg[indexPostcode]*gewicht} euro kosten");


