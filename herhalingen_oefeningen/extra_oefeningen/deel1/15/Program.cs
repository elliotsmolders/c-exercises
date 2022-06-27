//Toon alle priemgetallen van 1 tot n.

 Console.WriteLine("geef n:");
 int n = Convert.ToInt32(Console.ReadLine());
 bool isPriem;

 for(int i = 2;i<=n;i++){
    isPriem=true;
    for (int j = 2; j < i; j++)
    {
        if(i%j==0){
            isPriem=false;
            break;
        }
    }
    if(isPriem){
        Console.WriteLine(i);
    }
 }











/* Schrijf een programma dat controleert of een getal priem is of niet.
 */
/*  Console.WriteLine("geef een getal:");
 int getal = Convert.ToInt32(Console.ReadLine());
 bool isPriem=true;
 for(int i = 2;i<getal;i++){
    if(getal%i==0){
        isPriem = false;
        break;
    }
 }
 Console.WriteLine($"{getal} {(isPriem?"is":"is niet")} priem"); */