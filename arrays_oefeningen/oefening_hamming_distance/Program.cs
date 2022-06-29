/* Hamming distance
De hamming distance is het aantal tekens dat twee reeksen verschillen indien we ieder element vergelijken op dezelfde plaats in de andere 
reeks.

Maak een programma dat aan de gebruiker vraagt om twee DNA strings in te voeren (een reeks bestaande uit de letters G, A, C & T). Beide
 reeksen moeten even lang zijn.

Bereken de hamming distance tussen beide reeksen.

De hamming distance van volgende twee DNA strings is 7, omdat er 7 elementen in beide strings staan die niet gelijk zijn aan mekaar op
 dezelfde plek (aangeduid met ^). */


static char GetAllowedInput(){
    string allowedInput = "GACT";
    char userInput = '\0';
    System.Console.WriteLine("Give next part of the DNA sequence");
    userInput = Convert.ToChar(Console.ReadLine());
    while(!allowedInput.Contains(userInput)){
        System.Console.WriteLine("Wrong input, DNA only consists of 'A' 'G' 'C' 'T', try again:");
        userInput = Convert.ToChar(Console.ReadLine());
    };
    return userInput;
}


static char[] FillCharArray (char[] arr){
    for(int i = 0; i<arr.Length;i++){
        arr[i] = GetAllowedInput();
    }
    System.Console.WriteLine($"Array filled: {String.Join(',',arr)}");
    return arr;
}

static int CalcHammingDistance(char[]arr1, char[]arr2){
    int count = 0;
    for(int i = 0;i<arr1.Length;i++){
        if(arr1[i] != arr2[i]){count++;}
    }
    return count;
}

System.Console.WriteLine("Give DNA length");
int length = Convert.ToInt32(Console.ReadLine());
char[] arr1 = new char[length];
char[] arr2 = new char[length];
FillCharArray(arr1);
FillCharArray(arr2);
System.Console.WriteLine($"Hamming distance: {CalcHammingDistance(arr1,arr2)}");
/* GAGCCTACTAACGGGAT length 17
CATCGTAATGACGGCCT  hamming distance = 7*/