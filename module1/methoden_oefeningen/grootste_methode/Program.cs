/* Grootste methode
Schrijf een methode die 3 ints aanvaardt en vervolgens de grootste van de 3 parameters als resultaat terug geeft */
static int GrootsteVan3(int getal1,int getal2,int getal3){
    int grootste = getal1;
    if(getal2>grootste){
        grootste = getal2;
    }
    if(getal3>grootste){
        grootste=getal3;
    }
    return grootste;
}

System.Console.WriteLine(GrootsteVan3(4,2,6));