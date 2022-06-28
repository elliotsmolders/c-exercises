/* Maak een programma dat aan de gebruiker vraagt om 10 waarden (int) in te voeren in een array. Vervolgens toont het programma de som, het
 gemiddelde en het grootste getal van deze 10.

Vervolgens vraagt het programma de gebruiker om een getal in te voeren. Het programma toont dan alle getallen die groter of gelijk zijn aan
 dit ingevoerde getal zijn die in de array aanwezig zijn. Indien geen getallen groter zijn dan verschijnt een bericht Niets is groter op het
  scherm. */
static void VraagGetal(){
Console.WriteLine("Geef een getal:");
}
static int LeesGetal(){
    return Convert.ToInt32(Console.ReadLine());
}
static double BerekenGemiddelde(double som,double aantal){
    return som/aantal;
}
static int[] GetallenGroter(int[] arr,int getalMinimum){
    return Array.FindAll(arr,getal=>getal>getalMinimum);
}
static void HandleResultArray(int[]arr){
    System.Console.WriteLine((arr.Length==0?"Niets is groter" : String.Join(',',arr)));
}


int som = 0;
int numbersAmount = 10;
int[] arr1 = new int[numbersAmount];
for(int i = 0; i<arr1.Length;i++){
    VraagGetal();
    int getal = LeesGetal();
    som+= getal;
    arr1[i] = getal;
}
System.Console.WriteLine($"som: {som}");
System.Console.WriteLine($"gemiddelde: {BerekenGemiddelde(som,numbersAmount)}");
System.Console.WriteLine($"biggest number: {arr1.Max()}");
VraagGetal();
HandleResultArray(GetallenGroter(arr1,LeesGetal()));
