/* Maak een methode die jezelf voorstelt op het scherm in de vorm van “Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat
 666”. Deze informatie mag hardcoded in je methode staan. Bedoeling is dat je de methode kan aanroepen als volgt:

MyIntro(); */

static void MyIntro(){
System.Console.WriteLine("Ik ben Tim Dams, ik ben 18 jaar oud en woon in de Lambrisseringsstraat 666");
}
MyIntro();

/*Zorg er voor dat je nu je naam, leeftijd en adres via parameters kan meegeven en dus de methode als volgt kunt aanhouden:
MyIntro("Jos", 34, "Trammezantlei 21");
*/
static void MyIntro2(string naam, int leeftijd, string adres){
    System.Console.WriteLine($"Ik ben {naam}, ik ben {leeftijd} jaar oud en woon in {adres}");
}
MyIntro2("Jos", 34, "Trammezantlei 21");