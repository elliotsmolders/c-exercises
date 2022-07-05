// (PRO) Schrijf een programma dat het aantal digits in een getal telt (het getal 12348 heeft bijvoorbeeld 5 digits).

/* zonder loops:
 Console.WriteLine("geef getal in:");
string getal = Console.ReadLine();
Console.WriteLine($"{getal} bevat {getal.Length} digits");
 */
 //met loops:
 Console.WriteLine("geef een getal in:");
 int getal = Convert.ToInt32(Console.ReadLine());
 int temp = getal;
 int digits = 0;
 while(temp>0){
    temp = temp/10;
    digits++;
 }
 Console.WriteLine($"{getal} bevat {digits} digits");