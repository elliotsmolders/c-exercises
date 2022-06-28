/* 

Per array: output de array naar het scherm, maar ieder element naast elkaar met komma gescheiden. Dus niet:

true
false
true
\\etc
maar wel: true, false, true, ... */

//Maak een array gevuld met de getallen 0 tot 10
int[] arr1 = new int[11];
for(int i =0;i<=10;i++){
    arr1[i] = i;
}
string arr1String = String.Join(',',arr1);

//Maak een array gevuld met de getallen van 100 tot 1
int [] arr2 = new int[100];
for(int i = 1; i<=100; i++){
    arr2[i-1] = i;
}
Array.Reverse(arr2);
string arr2String = String.Join(',',arr2);

//Maak een array gevuld met de letters a tot z
char[] arr3 = new char[26];
for(int i = 97;i<=122;i++){
    arr3[i-97] = Convert.ToChar(i);
}
string arr3String = String.Join(',',arr3);

//Maak een array gevuld met willekeurige getallen tussen 1 en 100 (de array is 20 lang)
Random myRandomGen = new Random();
int[] arr4 = new int[20];
for(int i = 1;i<=20;i++){
    arr4[i-1] = myRandomGen.Next(1,101);
}
string arr4String = String.Join(',',arr4);

//Maak een array gevuld met afwisselend true en false (de array is 30 lang)
bool[] arr5 = new bool[30];
for(int i = 0;i<30;i++){
    arr5[i] = i%2==0?true:false;
}
string arr5String = String.Join(',',arr5);

//output naar scherm:

System.Console.WriteLine($"oefening 1: {arr1String}");
System.Console.WriteLine($"oefening 2: {arr2String}");
System.Console.WriteLine($"oefening 3: {arr3String}");
System.Console.WriteLine($"oefening 4: {arr4String}");
System.Console.WriteLine($"oefening 5: {arr5String}");