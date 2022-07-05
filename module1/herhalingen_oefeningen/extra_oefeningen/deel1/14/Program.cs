/* Schrijf een programma dat controleert of een getal priem is of niet.
 */
 Console.WriteLine("geef een getal:");
 int getal = Convert.ToInt32(Console.ReadLine());
 bool isPriem=true;
 for(int i = 2;i<getal;i++){
    if(getal%i==0){
        isPriem = false;
        break;
    }
 }
 Console.WriteLine($"{getal} {(isPriem?"is":"is niet")} priem");