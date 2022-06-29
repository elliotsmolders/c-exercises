/* Parkeergarage
Een parkeergarage vraagt sowieso €2.00 om tot maximum 3uur te parkeren. Per extra uur NA die 3uur wordt telkens €0.50 aangerekend (dus 4uur parkeren kost €2.50. Er wordt maximum €10 aangerekend per dag. Veronderstel dat er nooit langer dan 1 dag (24u) kan geparkeerd worden.

Schrijf een programma dat het verschuldigde bedrag toont gegeven de duur dat de parkeergarage gebruikt werd. Bij het opstarten van het programma wordt eerst gevraagd hoeveel auto’s ingevoerd zullen worden, dan wordt per auto de duur van het parkeren gevraagd. Finaal wordt, netjes getabuleerd, alle informatie getoond, inclusief het totaal bedrag. Gebruik minstens 1 methode ‘berekenKosten’ die de kost voor 1 gebruiker telkens teruggeeft, gegeven de duur als parameter. Gebruik ook een methode die een array als parameter aanvaard (bijvoorbeeld de array met daarin de respectievelijke uren per auto).

Voorbeeldoutput: Opstart:

Geef aantal auto's in: 


Geef parkeertijd auto 1 in (uren):
Geef parkeertijd auto 2 in (uren):
etc..
Resultaat:

Auto    Duur    Kost
1    x    y
2    x    y
..
2(=totaal aantal auto's)    som(x)    som(y) */
static int[] FillIntArray(int[]arr){
    for(int i = 0; i<arr.Length;i++){
        System.Console.WriteLine($"Geef parkeertijd auto {i+1}:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

static double BerekenKosten(int tijdInUur){
    if(tijdInUur<3){
        return 2;
    }
    return (tijdInUur-3)*0.5 + 2 > 10 ? 10 : (tijdInUur-3)*0.5 + 2;
}
static double[] ArrayVermenigvuldigen(int[]arr1){
    double[] arr2 = new double[arr1.Length];
    for(int i = 0; i<arr1.Length;i++){
        arr2[i] = BerekenKosten(arr1[i]);
    }
    return arr2;
}

static void PrintOutput(int[]arr1, double[]arr2,int sumArr1,double sumArr2){
    System.Console.WriteLine("Auto\t\tDuur\t\tKost");
    for(int i = 0; i<arr1.Length;i++){
        System.Console.WriteLine($"{i+1}\tx\t{arr1[i]}\t=\t{arr2[i]}");
    }
    System.Console.WriteLine($"{arr1.Length}\t\t{sumArr1}\t=\t{sumArr2}");

}

static int SumIntArray(int[]arr){
    int sum = 0;
    for(int i = 0; i<arr.Length;i++){
        sum+= arr[i];
    }
    return sum;
}

static double SumDoubleArray(double[]arr){
    double sum = 0;
    for(int i = 0; i<arr.Length;i++){
        sum+= arr[i];
    }
    return sum;
}

System.Console.WriteLine("Hoeveel autos zullen ingevoerd worden?");
int[] arrOfTimes = new int[Convert.ToInt32(Console.ReadLine())];
FillIntArray(arrOfTimes);
double[] arrOfCosts = ArrayVermenigvuldigen(arrOfTimes);
int totalTime = SumIntArray(arrOfTimes);
double totalCost = SumDoubleArray(arrOfCosts);
PrintOutput(arrOfTimes,arrOfCosts,totalTime,totalCost);