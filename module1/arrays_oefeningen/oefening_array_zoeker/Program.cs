/* Maak een programma dat eerst weer aan de gebruiker om 10 waarden vraagt die in een array worden gezet.

Vervolgens vraagt het programma welke waarde verwijderd moet worden. Wanneer de gebruiker hierop antwoordt met een nieuwe waarde dan zal deze
 nieuw ingevoerde waarde in de array gezocht worden. Indien deze gevonden wordt dan wordt deze waarde uit de array verwijderd en worden alle
 waarden die erachter komen met een plaatsje naar links opgeschoven, zodat achteraan de array terug een lege plek komt.

Deze laatste plek krijgt de waarde -1.

Toon vervolgens alle waarden van de array.

Indien de te zoeken waarde meer dan 1 keer voorkomt, wordt enkel de eerst gevonden waarde verwijderd. */

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
static int IsGetalInArray (int getalToCheck, int[]arr ){
    return Array.FindIndex(arr,getal=>getal==getalToCheck);
}
static int[] ShiftLeft(int[]arr,int indexStart=0, int shiftSize =1){
    for(int i = indexStart;i<arr.Length-shiftSize;i++){
        arr[i]=arr[i+1];
    }
    for(int i = arr.Length-shiftSize;i<arr.Length;i++){
        arr[i] = -1;
    }
    return  arr;
}




int[] arr1 = ArrayCreator(10);
System.Console.WriteLine("Welke getal verwijderen?");
int teVerwijderen = ReadNumber();
int indexTeVerwijderen = IsGetalInArray(teVerwijderen,arr1);
if(indexTeVerwijderen!=-1){
    ShiftLeft(arr:arr1,indexStart:indexTeVerwijderen,1);
}
else{
    System.Console.WriteLine($"{teVerwijderen} is niet in de array");
}
System.Console.WriteLine(String.Join(',',arr1));