/* ArrayOefener 2
Maak een programma dat aan de gebruiker vraagt om 2 keer 5 getallen in te voeren. Bewaar de eerste reeks waarden in een array A, de 
tweede reeks waarden in array B. Maak een nieuwe array C aan die steeds de som bevat van het respectievelijke element uit arrays A en B. 
Toon het resultaat. */
static int[] ArrayCreator(int length = 5){
    System.Console.WriteLine($"Making new array with length {length}");
    int[]arr = new int[length];
    for(int i = 0; i<length;i++){
        AskNumber();
        arr[i] = ReadNumber();
    }
    return arr;
}

static void AskNumber(){
    Console.WriteLine("Give a number: ");
}

static int ReadNumber(){
    return Convert.ToInt32(Console.ReadLine());
}

static int[] SumArraysSameLength(int[]arr1, int[]arr2){
    int[]arr3=new int[arr1.Length];
    for(int i =0; i < arr1.Length;i++){
        arr3[i] = arr1[i]+arr2[i];
    }
    return arr3;
}

int[] A = ArrayCreator();
int[] B = ArrayCreator();
int[] C = SumArraysSameLength(A,B);
System.Console.WriteLine($"Array A = {String.Join(',',A)}");
System.Console.WriteLine($"Array B = {String.Join(',',B)}");
System.Console.WriteLine($"Array C = {String.Join(',',C)}");

