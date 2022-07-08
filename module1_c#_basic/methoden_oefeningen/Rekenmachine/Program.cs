/*
Maak minimaal de methoden genaamd TelOp, TrekAf, VermenigVuldig en Deel. Je kan aan deze methoden steeds twee doubles meegeven en het resultaat
 dat terugkomt is uiteraard de bewerking van die twee parameters. Maak een eenvoudig programmatje waarin je die methoden test. Kan je een
  eenvoudige rekenmachine maken (inclusief geheugen)? Voeg extra methoden naar keuze toe (denk aan macht, sinus, cosinus, modulo, etc.).
*/
static double TelOp(double getal1,double getal2){
    return getal1+getal2;
}
System.Console.WriteLine(TelOp(4.3,3.2));


static double TrekAf(double getal1, double getal2){
    return getal1-getal2;
}
System.Console.WriteLine(TrekAf(4.2,5.3));

static double VermenigVuldig(double getal1, double getal2){
    return getal1*getal2;
}
System.Console.WriteLine(VermenigVuldig(4.2,5.3));

static double Deel(double getal1,double getal2){
    return getal1/getal2;
}
System.Console.WriteLine(Deel(4,3));