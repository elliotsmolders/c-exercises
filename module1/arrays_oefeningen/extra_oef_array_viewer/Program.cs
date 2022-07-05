/* Maak een programma dat een methode VisualiseerArray implementeert. De methode zal een array (type int) als parameter hebben en niets teruggeven (void). Echter, de methode zal met behulp van Write() de array, van eender welke grootte, op het scherm tonen. Tussen ieder element van dezelfde rij dient een tab (‘\t’) gezet te worden. Je dient in de methode gebruik te maken van een for-loop. Voorbeeld van main: */

static void VisualiseerArray(int[]arr){
    System.Console.WriteLine();
    for(int i = 0; i<arr.Length;i++){
        if(i!=arr.Length-1){
            Console.Write($"{arr[i]}\t");
        }
        else{
            Console.Write(arr[i]);
        }
    }
}
int[] arr1 = {15,6,9};
int[] arr2 = {1,2,3,4,5,6};

VisualiseerArray(arr1);
VisualiseerArray(arr2);