/*Schrijf een programma een getal n ontbindt in factoren. Factoren zijn de getallen waardoor je n kan delen zonder rest (van bijvoorbeeld het
 getal 100 zijn de factoren 1, 2, 4, 5, 10, 20, 25, 50 en 100).
 */
 Console.WriteLine("geef getal:");
 int getal = Convert.ToInt32(Console.ReadLine());
 for(int i= 1;i<=getal;i++){
    if(getal%i==0){
        Console.WriteLine(i);
    }
 }